using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.Informix;
using System.Data.Odbc;



namespace Proyecto1TBD2
{

    public partial class Inicio : Form
    {
        TextBox userTextBox;
        TextBox passwordTextBox;
        ToolStripMenuItem Option1;
        ToolStripMenuItem Option2;
        ToolStripMenuItem Option3;//agregar base de datos
        ToolStripMenuItem Option4;
        ToolStripMenuItem Option5;
        ToolStripMenuItem Option6;
        ToolStripMenuItem Option7;
        ToolStripMenuItem Option8;
        ToolStripMenuItem Option9;
        ToolStripMenuItem Option10;
        ToolStripMenuItem Option11;
        ToolStripMenuItem Option12;
        ToolStripMenuItem Option13;
        ToolStripMenuItem Option14;
        ToolStripMenuItem Option15;
        ToolStripMenuItem Option16;
        ToolStripMenuItem Option17;
        ToolStripMenuItem Option18;
        ToolStripMenuItem Option19;//Eliminar Base de datos
        ToolStripMenuItem Option20;//Agregar tabla 
        ToolStripMenuItem Option21;//Agregar tabla
        ToolStripMenuItem Option22;//Manipular datos
        ToolStripMenuItem Option23;//Agregar funcion
        ToolStripMenuItem Option24;//Agregar procedure
        ToolStripMenuItem Option25;//Manipular procedure
        ToolStripMenuItem Option26;//eliminar procedure
        ToolStripMenuItem Option27;//agregar procedure
        ToolStripMenuItem Option28;//agregar procedure

        Form Login;
        ContextMenuStrip OptionsMenu1;
        ContextMenuStrip OptionsMenu2;
        ContextMenuStrip OptionsMenu3;
        ContextMenuStrip OptionsMenu4;
        ContextMenuStrip OptionsMenu5;
        ContextMenuStrip OptionsMenu6;
        ContextMenuStrip OptionsMenu7;
        ContextMenuStrip OptionsMenu8;
        ContextMenuStrip OptionsMenu9;
        ContextMenuStrip OptionsMenu10;
        ContextMenuStrip OptionsMenu11;
        ContextMenuStrip OptionsMenu12; //agregar funcion
        ContextMenuStrip OptionsMenu13;
        ContextMenuStrip OptionsMenu14;//agregar procedure
        ContextMenuStrip OptionsMenu15;//agregar trigger
        bool connected = false;
        string user;
        string pass;
        string dbName;
        string auxdb;
        string nodeSelected;
        List<string> lstDatabases;
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeMenuTreeView();
            Option1.Click += new EventHandler(LoadControls);
            Option2.Click += new EventHandler(CloseConnection);
            Option4.Click += new EventHandler(VerRegistros);
            Option5.Click += new EventHandler(ModificarTabla);
            Option6.Click += new EventHandler(EliminarTabla);
            Option7.Click += new EventHandler(VerVistas);
            Option8.Click += new EventHandler(ModificarVista);
            Option9.Click += new EventHandler(EliminarVista);
            Option10.Click += new EventHandler(VerIndice);
            Option11.Click += new EventHandler(ManipularIndices);
            Option12.Click += new EventHandler(EliminarIndices);
            Option13.Click += new EventHandler(VerFuncion);
            Option15.Click += new EventHandler(EliminarFuncion);
            Option16.Click += new EventHandler(VerTrigger);
            Option18.Click += new EventHandler(EliminarTrigger);
            Option20.Click += new EventHandler(AgregarTabla);
            Option21.Click += new EventHandler(AgregarVista);
            Option22.Click += new EventHandler(ManipularDatos);
            Option23.Click += new EventHandler(AgregarFuncion);
            Option24.Click += new EventHandler(VerProcedimiento);
            Option26.Click += new EventHandler(EliminarProcedimiento);
            Option27.Click += new EventHandler(AgregarFuncion);//agregar procedure
            Option28.Click += new EventHandler(AgregarTrigger);//agregar procedure
        }

        protected void InitializeMenuTreeView()
        {
            MenuTreeView.Nodes.Add("Informix-SQL");
            MenuTreeView.Nodes.Add("Comandos-SQL");
            Option1 = new ToolStripMenuItem();
            Option1.Text = "Conectar";
            Option2 = new ToolStripMenuItem();
            Option2.Text = "Desconectar";
            Option3 = new ToolStripMenuItem();
            Option3.Text = "Agregar Base de datos";
            Option4 = new ToolStripMenuItem();
            Option4.Text = "Ver Registros";
            Option5 = new ToolStripMenuItem();
            Option5.Text = "Modificar Tabla";
            Option6 = new ToolStripMenuItem();
            Option6.Text = "Eliminar Tabla";
            Option7 = new ToolStripMenuItem();
            Option7.Text = "Ver Registros";
            Option8 = new ToolStripMenuItem();
            Option8.Text = "Modificar Vista";
            Option9 = new ToolStripMenuItem();
            Option9.Text = "Eliminar Vista";
            Option10 = new ToolStripMenuItem();
            Option10.Text = "Ver Indice";
            Option11 = new ToolStripMenuItem();
            Option11.Text = "Manipular Datos";
            Option12 = new ToolStripMenuItem();
            Option12.Text = "Eliminar Indice";
            Option13 = new ToolStripMenuItem();
            Option13.Text = "Ver Funcion";
            Option14 = new ToolStripMenuItem();
            Option14.Text = "Modificar Funcion";
            Option15 = new ToolStripMenuItem();
            Option15.Text = "Eliminar Funcion";
            Option16 = new ToolStripMenuItem();
            Option16.Text = "Ver Disparador";
            Option17 = new ToolStripMenuItem();
            Option17.Text = "Modificar Disparador";
            Option18 = new ToolStripMenuItem();
            Option18.Text = "Eliminar Disparador";
            Option19 = new ToolStripMenuItem();
            Option19.Text = "Eliminar BD";
            Option20 = new ToolStripMenuItem();
            Option20.Text = "Agregar tabla";
            Option21 = new ToolStripMenuItem();
            Option21.Text = "Agregar vista";
            Option22 = new ToolStripMenuItem();
            Option22.Text = "Manipular Datos";
            Option23 = new ToolStripMenuItem();
            Option23.Text = "Agregar funcion";
            Option24 = new ToolStripMenuItem();
            Option24.Text = "Ver Procedimiento";
            Option25 = new ToolStripMenuItem();
            Option25.Text = "Modificar Procedimiento";
            Option26 = new ToolStripMenuItem();
            Option26.Text = "Eliminar Procedimiento";
            Option27 = new ToolStripMenuItem();
            Option27.Text = "Agregar Procedimiento";
            Option28 = new ToolStripMenuItem();
            Option28.Text = "Agregar Disparador";
            OptionsMenu1 = new ContextMenuStrip();
            OptionsMenu2 = new ContextMenuStrip();
            OptionsMenu3 = new ContextMenuStrip();
            OptionsMenu4 = new ContextMenuStrip();
            OptionsMenu5 = new ContextMenuStrip();
            OptionsMenu6 = new ContextMenuStrip();
            OptionsMenu7 = new ContextMenuStrip();
            OptionsMenu8 = new ContextMenuStrip();
            OptionsMenu9 = new ContextMenuStrip();
            OptionsMenu10 = new ContextMenuStrip();
            OptionsMenu11 = new ContextMenuStrip();
            OptionsMenu12 = new ContextMenuStrip();
            OptionsMenu13 = new ContextMenuStrip();
            OptionsMenu14 = new ContextMenuStrip();
            OptionsMenu15 = new ContextMenuStrip();
            MenuTreeView.Nodes[0].ContextMenuStrip= OptionsMenu1;//en conexion
            OptionsMenu1.Items.AddRange(new ToolStripMenuItem[] { Option1, Option2 });
            OutputMessage.Text = "*************Seleccione accion a ejecutar";
        }

        protected void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (connected) { Option1.Enabled = false; Option2.Enabled = true; }
            else { Option1.Enabled = true; Option2.Enabled = false; }
            nodeSelected = e.Node.Text;
            auxdb = e.Node.FullPath;
        }

        protected void VerRegistros(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cmd = "Select * from " + nodeSelected.Trim();
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE= " +
                    dbName + ";" +
                    "UID=" +
                     user + ";" +
                    "PWD=" +
                    pass + ";";
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                ListData.DataSource = data;
                OutputMessage.Text = "Completado con 0 errores";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }


        protected void ManipularDatos(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            RecordsManagement recordsManagement = new RecordsManagement();
            recordsManagement.Parameters(dbName, user, pass,nodeSelected);
            recordsManagement.LoadColumns();
            recordsManagement.ShowDialog();
        }

        protected void ModificarVista(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            ViewManagement viewManagement = new ViewManagement();
            viewManagement.Parameters(dbName, user, pass, nodeSelected);
            viewManagement.LoadColumns();
            viewManagement.ShowDialog();
        }


        protected void ManipularIndices(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            IndexManagement recordsManagement = new IndexManagement();
            recordsManagement.Parameters(dbName, user, pass);
            recordsManagement.ShowDialog();
        }


        protected void EliminarIndices(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop index"+" " + nodeSelected;
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Indice eliminado");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar indice");
            }
;
        }



        protected void AgregarFuncion(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            AddProcedure addProcedure = new AddProcedure();
            addProcedure.Parameters(dbName, user, pass);
            addProcedure.ShowDialog();
        }

        protected void VerFuncion(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            string cmd = "select procname, owner, procid, mode, retsize,symsize,isproc" +
                           " from sysprocedures where procname ="+ "'"+nodeSelected+"'"+
                           "and isproc='f'";
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
            pass + ";";
            conn.ConnectionString = cs;
            try
            {
                DataTable tmpTable = new DataTable();
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                adapter.Fill(tmpTable);
                ListData.DataSource = tmpTable;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }


        protected void EliminarFuncion(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop function "+ nodeSelected;
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Funcion Eliminada");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar funcion");
            }

        }

        protected void VerProcedimiento(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            string cmd = "select procname, owner, procid, mode, retsize,symsize,isproc" +
                           " from sysprocedures where procname =" + "'" + nodeSelected + "'" +
                           "and isproc='t'";
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
            pass + ";";
            conn.ConnectionString = cs;
            try
            {
                DataTable tmpTable = new DataTable();
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                adapter.Fill(tmpTable);
                ListData.DataSource = tmpTable;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }


        protected void EliminarProcedimiento(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop procedure " + nodeSelected;
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Procedimiento Eliminado");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar procedimiento");
            }

        }


        protected void VerVistas(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cmd = "Select * from " + nodeSelected.Trim();
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE= " +
                    dbName + ";" +
                    "UID=" +
                     user + ";" +
                    "PWD=" +
                    pass + ";";
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                ListData.DataSource = data;
                OutputMessage.Text = "Completado con 0 errores";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        protected void AgregarTrigger(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            AddTrigger addTrigger = new AddTrigger();
            addTrigger.Parameters(dbName, user, pass);
            addTrigger.ShowDialog();
        }

        protected void VerTrigger(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            string cmd = "select * from systriggers where trigname = " +
                            "'" + nodeSelected + "'";               
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
            pass + ";";
            conn.ConnectionString = cs;
            try
            {
                DataTable tmpTable = new DataTable();
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                adapter.Fill(tmpTable);
                ListData.DataSource = tmpTable;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        protected void EliminarTrigger(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop trigger " + nodeSelected;
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Disparador Eliminado");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar disparador");
            }

        }





        protected void AgregarTabla(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            AddTable addTable = new AddTable();
            addTable.Parameters(dbName, user, pass);
            addTable.ShowDialog();
        }

        protected void ModificarTabla(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            ModifyTable modifyTable = new ModifyTable();
            modifyTable.Parameters(dbName, user, pass, nodeSelected);
            modifyTable.LoadRecords();
            modifyTable.ShowDialog();
        }

        protected void EliminarTabla(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop table " + nodeSelected+";";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Tabla eliminada");
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar tabla");
            }
        }


        protected void VerIndice(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            string cmd = "select si.idxname, si.owner, si.tabid, st.tabname "+
                "from sysindexes si inner "+
                "join systables st "+
                "on si.tabid = st.tabid"+" ";
              cmd += "where si.idxname=" + "'"+ nodeSelected+"'";
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 dbName + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                MessageBox.Show(cmd);
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    ListData.DataSource = tmpTable;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }


        protected void AgregarVista(object sender, EventArgs e)
        {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            AddView addView = new AddView();
            addView.Parameters(dbName, user, pass);
            addView.ShowDialog();
        }

        protected void EliminarVista(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcCommand commandAdd;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
            "HOST=127.0.0.1; " +
            "SERVER=lo_informix1410;" +
            "DATABASE=" +
             dbName + ";" +
            "SERVICE=lo_informix1410;" +
            "PROTOCOL=olsoctcp;" +
            "UID=" +
             user + ";" +
            "PWD=" +
             pass + ";";
            string cmd = "drop view " + nodeSelected + ";";
            MessageBox.Show(cmd);
            conn.ConnectionString = cs;
            try
            {
                conn.Open();
                commandAdd = new OdbcCommand(cmd, conn);
                commandAdd.ExecuteNonQuery();
                MessageBox.Show("Vista eliminada");       
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al eliminar vista");
            }
        }


        private void LoadControls(object sender, EventArgs e)
        {
            Login = new Form();
            Label userLabel = new Label();
            Label passwordLabel = new Label();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            Button Conectar = new Button();
            Button Salir = new Button();
            userLabel.Text = "Usuario: ";
            passwordLabel.Text = "Contraseña: ";
            Login.Text = "Login";
            Conectar.Text = "Iniciar";
            Salir.Text = "Salir";
            Login.AcceptButton = Conectar;
            Login.CancelButton = Salir;
            Login.FormBorderStyle = FormBorderStyle.FixedDialog;
            Login.StartPosition = FormStartPosition.CenterScreen;
            userLabel.Location = new Point(10, 20);
            userTextBox.Location = new Point(140, 20);
            passwordLabel.Location = new Point(10, 50);
            passwordTextBox.Location = new Point(140, 50);
            Conectar.Location = new Point(40, 130);
            Salir.Location = new Point(150, 130);
            passwordTextBox.PasswordChar = '*';
            Login.Size = new Size(280, 230);
            Login.Controls.Add(userLabel);
            Login.Controls.Add(passwordLabel);
            Login.Controls.Add(userTextBox);
            Login.Controls.Add(passwordTextBox);
            Login.Controls.Add(Conectar);
            Login.Controls.Add(Salir);
            Conectar.Click += new EventHandler(ConectarDB_Click);
            Login.ShowDialog();
        }

        private void ConectarDB_Click(object sender, EventArgs e)
        {
            OdbcConnection conn;
            user = userTextBox.Text;
            pass = passwordTextBox.Text;
            if (user.Length == 0 || pass.Length == 0)
            {
                MessageBox.Show("Hay Datos vacios, revise");
            }
            else
            {
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE=sysmaster; " +
                    "UID=" +
                     user + ";" +
                    "PWD=" +
                    pass + ";";
                try
                {
                    conn = new OdbcConnection(cs);
                    conn.Open();
                    MessageBox.Show("Conectado");
                    btnActualizar.Enabled = true;
                    connected = true;
                    Login.DialogResult = DialogResult.OK;
                    Login.Close();
                    ListDataBases();
                    ListDataBaseOptions();
                    ListTables();
                    ListViews();
                    ListIndexes();
                    ListFunctions();
                    ListTriggers();
                    ListProcedures();
                    OptionsMenu();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
            }
        }

        protected void OptionsMenu()
        {
            OptionsMenu2.Items.AddRange(new ToolStripMenuItem[] { Option4, Option22, Option5, Option6 });
            OptionsMenu3.Items.AddRange(new ToolStripMenuItem[] { Option7, Option8, Option9 });
            OptionsMenu4.Items.AddRange(new ToolStripMenuItem[] { Option10, Option12});
            OptionsMenu5.Items.AddRange(new ToolStripMenuItem[] { Option13, Option14, Option15 });
            OptionsMenu6.Items.AddRange(new ToolStripMenuItem[] { Option16, Option17, Option18 });
            OptionsMenu7.Items.AddRange(new ToolStripMenuItem[] { Option3 });
            OptionsMenu8.Items.AddRange(new ToolStripMenuItem[] { Option19 });
            OptionsMenu9.Items.AddRange(new ToolStripMenuItem[] { Option20 });
            OptionsMenu10.Items.AddRange(new ToolStripMenuItem[] { Option21 });
            OptionsMenu11.Items.AddRange(new ToolStripMenuItem[] { Option11 });
            OptionsMenu12.Items.AddRange(new ToolStripMenuItem[] { Option23 });
            OptionsMenu13.Items.AddRange(new ToolStripMenuItem[] { Option24, Option25, Option26 });
            OptionsMenu14.Items.AddRange(new ToolStripMenuItem[] { Option27 });
            OptionsMenu15.Items.AddRange(new ToolStripMenuItem[] { Option28 });

            MenuTreeView.Nodes[0].Nodes[0].ContextMenuStrip = OptionsMenu7;
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                int countTables = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes.Count;
                int countViews = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[1].Nodes.Count;
                int countIndexes = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[2].Nodes.Count;
                int countFunctions = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[3].Nodes.Count;
                int countTriggers = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[4].Nodes.Count;
                int countProcedures = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[5].Nodes.Count;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].ContextMenuStrip = OptionsMenu8;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].ContextMenuStrip = OptionsMenu9;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[1].ContextMenuStrip = OptionsMenu10;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[2].ContextMenuStrip = OptionsMenu11;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[3].ContextMenuStrip = OptionsMenu12;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[4].ContextMenuStrip = OptionsMenu15;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[5].ContextMenuStrip = OptionsMenu14;

                for (int j = 0; j < countTables; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].ContextMenuStrip = OptionsMenu2;
                }

                for (int j = 0; j < countViews; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[1].Nodes[j].ContextMenuStrip = OptionsMenu3;
                }
                for (int j = 0; j < countIndexes; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[2].Nodes[j].ContextMenuStrip = OptionsMenu4;
                }
                for (int j = 0; j < countFunctions; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[3].Nodes[j].ContextMenuStrip = OptionsMenu5;
                }
                for (int j = 0; j < countTriggers; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[4].Nodes[j].ContextMenuStrip = OptionsMenu6;
                }

                for (int j = 0; j < countProcedures; j++)
                {
                    MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[5].Nodes[j].ContextMenuStrip = OptionsMenu13;
                }
            }
        }

        protected void ListDataBases()
        {
            MenuTreeView.Nodes[0].Nodes.Add("lo_informix1410");
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            lstDatabases = new List<String>();
            string cmd = "select dbs_dbsname from sysmaster:informix.sysdbslocale;";
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=sysmaster;" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
            conn.ConnectionString = cs;
            try
            {
                DataTable tmpTable = new DataTable();
                conn.Open();
                adapter = new OdbcDataAdapter(cmd, conn);
                adapter.Fill(tmpTable);
                foreach (DataRow row in tmpTable.Rows)
                {
                    string aux = row[0].ToString();
                    string aux2 = aux.Trim();
                    if (aux2 != "sysmaster" && aux2 != "sysutils" &&
                       aux2 != "sysuser" && aux2 != "sysadmin")
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes.Add(aux);
                        lstDatabases.Add(aux);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        protected void ListDataBaseOptions()
        {
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Tablas");
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Vistas");
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Indices");
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Funciones");
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Disparadores");
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Procedimientos");
            }
        }

        protected void ListTables()
        {
            string cmd = "select tabname from systables where tabid>99 and partnum >0;";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        protected void ListViews()
        {
            string cmd = "select tabname  from systables st inner join " +
                         "sysviews sv on st.tabid=sv.tabid where st.tabid> 99 and " +
                        "st.partnum =0;";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[1].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }


        }

        protected void ListIndexes()
        {
            string cmd = "select idxname from sysindexes where tabid>99";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[2].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

        }

        protected void ListFunctions()
        {
            string cmd = "select procname from sysprocedures where procid>559 and isproc='f';";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[3].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        protected void ListProcedures()
        {
            string cmd = "select procname from sysprocedures where procid>559 and isproc='t';";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[5].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        protected void ListTriggers()
        {
            string cmd = "select trigname from systriggers;";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i] + ";" +
                "SERVICE=lo_informix1410;" +
                "PROTOCOL=olsoctcp;" +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
                conn.ConnectionString = cs;
                try
                {
                    DataTable tmpTable = new DataTable();
                    conn.Open();
                    adapter = new OdbcDataAdapter(cmd, conn);
                    adapter.Fill(tmpTable);
                    foreach (DataRow row in tmpTable.Rows)
                    {
                        MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[4].Nodes.Add(row[0].ToString());
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        private void CloseConnection(object sender, EventArgs e)
        {
            MenuTreeView.Nodes[0].Nodes.Clear();
            connected = false;
            btnActualizar.Enabled = false;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();  
        }


        private void UpdateData() {
            MenuTreeView.Nodes[0].Nodes.Clear();
            OdbcConnection conn;
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1;" +
                "SERVER=lo_informix1410;" +
                "DATABASE=sysmaster; " +
                "UID=" +
                 user + ";" +
                "PWD=" +
                pass + ";";
            try
            {
                conn = new OdbcConnection(cs);
                conn.Open();
                ListDataBases();
                ListDataBaseOptions();
                ListTables();
                ListViews();
                ListIndexes();
                ListFunctions();
                ListTriggers();
                ListProcedures();
                OptionsMenu();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void ListData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}


// DataTable data = new DataTable();
// adapter.Fill(data);
//datatablelist.DataSource = data;

/*
        private void ListServer() {
            string dir = "C:\\Program Files\\IBM Informix Software Bundle\\etc\\";
            char delimitador='.';
            string name;
            try
            {
                int i=0;
                foreach (string f in System.IO.Directory.GetFiles(dir))
                {
                    if (System.IO.Path.GetFileName(f).Contains("sqlhosts"))
                    {
                        name = System.IO.Path.GetFileName(f);                    
                        if (name != "sqlhosts.demo"){
                            serverName= name.Split(delimitador);
                            MenuTreeView.Nodes[0].Nodes[0].Nodes.Add(serverName[1]);
                            lstServer.Add(serverName[1]);
                        }
                    }
                    i++;
                }
                
            }
            catch (System.Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        

          " case "+ 
         "when (isproc) = 'f' then 'Funcion' "+
         "when (isproc) = 't' then 'Procedimiento' "+
         " end as Tipo "+
*/