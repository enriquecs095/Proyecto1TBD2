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
    public partial class AddTable : Form
    {
        string database;
        string userName;
        string password;
        public AddTable()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen; 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActionAddTable_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string tablename = tableName.Text;
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
            string cmd = "create table " + tablename + "(";
            for (int i = 0; i < getRows; i++)
            {
                cmd += DatosTable.Rows[i].Cells[0].Value.ToString() + " " +
                DatosTable.Rows[i].Cells[1].Value.ToString() + " ";
                if (DatosTable.Rows[i].Cells[2].Value != null)
                {
                    cmd += "not null ";
                }
                if (DatosTable.Rows[i].Cells[3].Value != null)
                {
                    cmd += "primary key";
                }
                if (i < getRows - 1)
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
                MessageBox.Show("Tabla agregada exitosamente");
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al crear tabla");
            }
        }

            
        private void AddTable_Load(object sender, EventArgs e)
        {

        }

        public void Parameters(string database, string username, string pass) {
            this.database = database;
            this.userName = username;
            this.password = pass;
        }
    }
}
