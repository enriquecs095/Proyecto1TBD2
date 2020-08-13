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
    public partial class IndexManagement : Form
    {
        string database;
        string userName;
        string password;

        public IndexManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void IndexManagement_Load(object sender, EventArgs e)
        {


        }



        public void Parameters(string database, string username, string pass)
        {
            this.database = database;
            this.userName = username;
            this.password = pass;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string tbname = tableName.Text;
            string cmd = "select sc.colname as Nombre," +
                            "case" +
                           " when MOD(sc.coltype,256)= 0 THEN 'char(20)'" +
                          "  when MOD(sc.coltype,256)= 2 THEN 'int'" +
                           " when MOD(sc.coltype,256)= 3 THEN 'float'" +
                           " when MOD(sc.coltype,256)= 5 THEN 'decimal'" +
                           " when MOD(sc.coltype,256)= 45 THEN 'boolean'" +
                           " end as Variable" +
                           " from syscolumns sc inner" +
                           " join" +
                           " systables st on sc.tabid = st.tabid" +
                           " where st.partnum > 0" +
                           " and st.tabid > 99" +
                           " and st.tabname = " + "'" + tbname + "'";
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
                DatosTable.DataSource = data;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }


        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string cellName = DatosTable.CurrentCell.ToString();
            string indexname = indexName.Text;
            string tablename = tableName.Text;
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
            string cmd = "create index" + " " + indexname + " " + "on";
            cmd += " " + tablename + "(" + cellName + ")";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
           /*
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Indice agregado exitosamente");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }*/
        }

    }

}
