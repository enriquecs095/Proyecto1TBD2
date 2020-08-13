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
    public partial class ModifyTable : Form
    {
        string database;
        string userName;
        string password;
        string tbName;
        List<string> lstNames;

        public ModifyTable()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        
        }

        public void LoadRecords()
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cmd = "select sc.colname as Nombre,"+
                            "case"+ 
                           " when MOD(sc.coltype,256)= 0 THEN 'char(20)'"+
                          "  when MOD(sc.coltype,256)= 2 THEN 'int'"+
                           " when MOD(sc.coltype,256)= 3 THEN 'float'"+
                           " when MOD(sc.coltype,256)= 5 THEN 'decimal'"+
                           " when MOD(sc.coltype,256)= 45 THEN 'boolean'"+
                           " end as Variable"+
                           " from syscolumns sc inner"+
                           " join"+
                           " systables st on sc.tabid = st.tabid"+
                           " where st.partnum > 0"+
                           " and st.tabid > 99"+
                           " and st.tabname = "+ "'"+this.tbName+"'";
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
                DatosTable.DataSource=data;
                SaveNames();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }


        private void SaveNames() {
            int getRows = DatosTable.Rows.Count - 1;
            lstNames = new List<string>();

            for (int i = 0; i < getRows; i++)
            {
                lstNames.Add(DatosTable.Rows[i].Cells[2].Value.ToString());
            }

        }

        private void ModifyTable_Load(object sender, EventArgs e)
        {
        
        }


        public void Parameters(string database, string username, string pass, string tablename)
        {
            this.database = database;
            this.userName = username;
            this.password = pass;
            this.tbName = tablename;
        }

        private void DatosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
         
            int getRows = DatosTable.Rows.Count - 1;
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
            string cmd=" ";

            for (int i = 0; i < getRows; i++)
            {
                string selectedText = Convert.ToString(DatosTable.Rows[i].Cells[0].FormattedValue.ToString());

                if (selectedText == "Modif. tipo col")
                {
                    cmd += "alter table "+this.tbName+" modify "+" ("+ DatosTable.Rows[i].Cells[2].Value.ToString()+" ";
                    cmd += DatosTable.Rows[i].Cells[1].Value.ToString()+")";
                  
                }
                if (selectedText == "Renombrar col")
                {

                    cmd += "rename column" + " " +this.tbName+"."+ lstNames[i]; 
                    cmd+= " to " + DatosTable.Rows[i].Cells[2].Value.ToString();
                    
                }
                if (selectedText == "Agregar col")
                {
                    cmd += "alter table "+this.tbName+" Add"+" "+ DatosTable.Rows[i].Cells[2].Value.ToString() +" " +DatosTable.Rows[i].Cells[1].Value.ToString();
                    
                }
                if (selectedText == "Eliminar col")
                {
    
                    cmd += "alter table "+this.tbName+" Drop " + DatosTable.Rows[i].Cells[2].Value.ToString();
                    
                }
            }
            cmd += ";";
            conn.ConnectionString = cs;
            MessageBox.Show(cmd);
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Tabla modificada exitosamente");              
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
