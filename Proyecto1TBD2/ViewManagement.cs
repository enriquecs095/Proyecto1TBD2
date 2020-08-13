using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Proyecto1TBD2
{
    public partial class ViewManagement : Form
    {
        string database;
        string userName;
        string password;
        string tbName;
        List<string> lstRecord;
        public ViewManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ViewManagement_Load(object sender, EventArgs e)
        {

        }

        public void LoadColumns()
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cmd = "select sc.colname as Nombre " +
                           " from syscolumns sc inner" +
                           " join" +
                           " systables st on sc.tabid = st.tabid" +
                           " where st.partnum = 0" +
                           " and st.tabid > 99" +
                           " and st.tabname = " + "'" + this.tbName + "'";
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE= " +
                    this.database + ";" +
                    "UID=" +
                     this.userName + ";" +
                    "PWD=" +
                    this.password + ";";
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                DatosTable.ColumnCount = data.Rows.Count;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DatosTable.Columns[i].HeaderText = data.Rows[i]["Nombre"].ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }



        public void Parameters(string database, string username, string pass, string tablename)
        {
            this.database = database;
            this.userName = username;
            this.password = pass;
            this.tbName = tablename;
        }


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            lstRecord = new List<string>();
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string find = numberRecord.Text;
            string colFind = DatosTable.Columns[0].HeaderText.ToString();
            string cmd = "select * from " + " " +
                          this.tbName + " " +
                          "where" + " " + colFind + "= '" + find + "'";
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE= " +
                    this.database + ";" +
                    "UID=" +
                     this.userName + ";" +
                    "PWD=" +
                    this.password + ";";
            conn.ConnectionString = cs;
            MessageBox.Show(cmd);
            try
            {
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    DatosTable.Rows[0].Cells[i].Value = data.Rows[0][DatosTable.Columns[i].HeaderText].ToString();
                    lstRecord.Add(data.Rows[0][DatosTable.Columns[i].HeaderText].ToString());
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Registro no existe");
            }

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             this.database + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             this.userName + ";" +
            "PWD=" +
            this.password + ";";
            string cmd = "insert into" + " " + this.tbName + " " + "values (";
            for (int i = 0; i < DatosTable.Columns.Count; i++)
            {
                cmd += "'" + DatosTable.Rows[0].Cells[i].Value.ToString() + "'";
                if (i < DatosTable.Columns.Count - 1)
                {
                    cmd += ",";
                }
            }
            cmd += ");";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            bool cambio = false;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             this.database + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             this.userName + ";" +
            "PWD=" +
            this.password + ";";
            string cmd = "update" + " " + this.tbName + " " + "set " + " ";
            for (int i = 0; i < DatosTable.Columns.Count; i++)
            {
                if (lstRecord[i] != DatosTable.Rows[0].Cells[i].Value.ToString())
                {
                    if (cambio)
                    {
                        cmd += ",";
                    }
                    cmd += DatosTable.Columns[i].HeaderText.ToString() + "=";
                    cmd += "'" + DatosTable.Rows[0].Cells[i].Value.ToString() + "'" + " ";
                    cambio = true;
                }
            }
            cmd += "where" + " " + DatosTable.Columns[0].HeaderText.ToString() + "=";
            cmd += "'" + DatosTable.Rows[0].Cells[0].Value.ToString() + "'";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             this.database + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             this.userName + ";" +
            "PWD=" +
            this.password + ";";
            string cmd = "delete from" + " " + this.tbName + " ";
            cmd += "where" + " " + DatosTable.Columns[0].HeaderText.ToString() + "=";
            cmd += "'" + DatosTable.Rows[0].Cells[0].Value.ToString() + "'";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Registro agregado exitosamente");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.DatosTable.Rows.Clear();
        }

    }
}
