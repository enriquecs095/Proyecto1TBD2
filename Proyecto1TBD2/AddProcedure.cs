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
    public partial class AddProcedure : Form
    {
        string database;
        string userName;
        string password;
        public AddProcedure()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
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
            string cmd = Commands.Text;
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error en statement, revise");
            }


        }


        public void Parameters(string database, string username, string pass)
        {
            this.database = database;
            this.userName = username;
            this.password = pass;
        }

        private void typeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = fpName.Text;
            string commandProcedure = "create procedure "+ name+"()" +" \n end procedure;";
            if (typeName.SelectedItem.ToString() == "Procedimiento")
            {
                Commands.Text = commandProcedure;
                this.lblretorna.Visible = false;
                this.lstVar.Visible = false;
            }
            else {
                this.lblretorna.Visible = true;
                this.lstVar.Visible = true;
            }

        }

        private void lstVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = fpName.Text;
            string commandFunction = "create function " + name +"()" +"\n returning " +lstVar.SelectedItem.ToString()+"\n end function;";
            Commands.Text = commandFunction;
           
        }

        private void lstaction_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
