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
        TreeNode displayMenu1;
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
            InitializeMenuTreeView();
            Option1.Click += new EventHandler(LoadControls);
            Option2.Click += new EventHandler(CloseConnection);
            Option4.Click += new EventHandler(VerRegistros);
            Option20.Click += new EventHandler(AgregarTabla);
        }

        protected void InitializeMenuTreeView()
        {
            MenuTreeView.Nodes.Add("Informix-SQL");
            MenuTreeView.Nodes.Add("NoSQL");
            displayMenu1 = new TreeNode("lo_informix1410");
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
            Option7.Text = "Ver Vistas";
            Option8 = new ToolStripMenuItem();
            Option8.Text = "Modificar Vistas";
            Option9 = new ToolStripMenuItem();
            Option9.Text = "Eliminar Vistas";
            Option10 = new ToolStripMenuItem();
            Option10.Text = "Ver Indices";
            Option11 = new ToolStripMenuItem();
            Option11.Text = "Modificar Indices";
            Option12 = new ToolStripMenuItem();
            Option12.Text = "Eliminar Indices";
            Option13 = new ToolStripMenuItem();
            Option13.Text = "Ver Funciones";
            Option14 = new ToolStripMenuItem();
            Option14.Text = "Modificar Funciones";
            Option15 = new ToolStripMenuItem();
            Option15.Text = "Eliminar Funciones";
            Option16 = new ToolStripMenuItem();
            Option16.Text = "Ver Disparadores";
            Option17 = new ToolStripMenuItem();
            Option17.Text = "Modificar Disparadores";
            Option18 = new ToolStripMenuItem();
            Option18.Text = "Eliminar Disparadores";
            Option19 = new ToolStripMenuItem();
            Option19.Text = "Eliminar BD";
            Option20 = new ToolStripMenuItem();
            Option20.Text = "Agregar tabla";
            OptionsMenu1 = new ContextMenuStrip();
            OptionsMenu2 = new ContextMenuStrip();
            OptionsMenu3 = new ContextMenuStrip();
            OptionsMenu4 = new ContextMenuStrip();
            OptionsMenu5 = new ContextMenuStrip();
            OptionsMenu6 = new ContextMenuStrip();
            OptionsMenu7 = new ContextMenuStrip();
            OptionsMenu8 = new ContextMenuStrip();
            OptionsMenu9 = new ContextMenuStrip();
            MenuTreeView.Nodes[0].Nodes.Add(displayMenu1);//en conexion
            OptionsMenu1.Items.AddRange(new ToolStripMenuItem[] { Option1, Option2 });
            displayMenu1.ContextMenuStrip = OptionsMenu1;
            OutputMessage.Text = "*************Seleccione accion a ejecutar";
        }

        protected void treeView1_AfterSelect(object sender, TreeViewEventArgs e){
                if (connected) { Option1.Enabled = false; Option2.Enabled = true; }
                  else { Option1.Enabled = true; Option2.Enabled = false; }
                nodeSelected = e.Node.Text;
                auxdb = e.Node.FullPath;
                    
        }

        protected void VerRegistros(object sender, EventArgs e) {
            char delimitador= '\\';
            string[] aux= auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            OdbcConnection conn = new OdbcConnection();
            OdbcDataAdapter adapter;
            string cmd = "Select * from " + nodeSelected.Trim();
            string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE= " +
                    dbName+";"+
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

        protected void AgregarTabla(object sender, EventArgs e) {
            char delimitador = '\\';
            string[] aux = auxdb.Split(delimitador);
            dbName = aux[2].Trim();
            AddTable addTable = new AddTable();
            addTable.ShowDialog();
        }

        private void LoadControls(object sender, EventArgs e) {
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
            userLabel.Location = new Point(10,20);
            userTextBox.Location = new Point(140, 20);
            passwordLabel.Location = new Point(10, 50);
            passwordTextBox.Location = new Point(140, 50);
            Conectar.Location = new Point(40, 130);
            Salir.Location = new Point(150, 130);
            passwordTextBox.PasswordChar = '*';
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
            if (user.Length == 0 || pass.Length == 0){
                MessageBox.Show("Hay Datos vacios, revise");
            }else{
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1;" +
                    "SERVER=lo_informix1410;" +
                    "DATABASE=sysmaster; " +
                    "UID=" +
                     user + ";" +
                    "PWD=" +
                    pass + ";";
                try{
                    conn = new OdbcConnection(cs);
                    conn.Open();
                    MessageBox.Show("Conectado");
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
                    OptionsMenu();
                }
                catch (Exception a){
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
            }
        }
        
       protected void OptionsMenu()
       {
            OptionsMenu2.Items.AddRange(new ToolStripMenuItem[] { Option4, Option5, Option6 });
            OptionsMenu3.Items.AddRange(new ToolStripMenuItem[] { Option7, Option8, Option9 });
            OptionsMenu4.Items.AddRange(new ToolStripMenuItem[] { Option10, Option11, Option12 });
            OptionsMenu5.Items.AddRange(new ToolStripMenuItem[] { Option13, Option14, Option15 });
            OptionsMenu6.Items.AddRange(new ToolStripMenuItem[] { Option16, Option17, Option18 });
            OptionsMenu7.Items.AddRange(new ToolStripMenuItem[] { Option3 });
            OptionsMenu8.Items.AddRange(new ToolStripMenuItem[] { Option19 });
            OptionsMenu9.Items.AddRange(new ToolStripMenuItem[] { Option20 });
            MenuTreeView.Nodes[0].Nodes[0].ContextMenuStrip = OptionsMenu7;
            for (int i = 0; i < lstDatabases.Count; i++) {
               int countTables= MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes.Count;
                int countViews = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[1].Nodes.Count;
                int countIndexes = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[2].Nodes.Count;
                int countFunctions = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[3].Nodes.Count;
                int countTriggers = MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[4].Nodes.Count;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].ContextMenuStrip = OptionsMenu8;
                MenuTreeView.Nodes[0].Nodes[0].Nodes[i].Nodes[0].ContextMenuStrip = OptionsMenu9;
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
            }  
       }

        protected void ListDataBases(){
            OdbcConnection conn = new OdbcConnection() ;
            OdbcDataAdapter adapter;
            lstDatabases = new List<String>();
                string cmd = "select dbs_dbsname from sysmaster:informix.sysdbslocale;";
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                    "HOST=127.0.0.1; " +
                    "SERVER=lo_informix1410;" +
                    "DATABASE=sysmaster;" +
                    "SERVICE=lo_informix1410;" +
                    "PROTOCOL=olsoctcp;"+
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
                        if (aux2 !="sysmaster" && aux2!="sysutils" &&
                           aux2 !="sysuser" && aux2!="sysadmin")
                            {
                                MenuTreeView.Nodes[0].Nodes[0].Nodes.Add(aux);
                                lstDatabases.Add(aux);
                            }
                    }                 
            }catch (Exception a){
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
            }
        }
        
        protected void ListTables()
        {
            string cmd = "select tabname from systables where tabid > 99;";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i]+";"+
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

        protected void ListViews() { 
         string cmd = "select tabid from sysviews;";
            for (int i = 0; i < lstDatabases.Count; i++)
            {
                OdbcConnection conn = new OdbcConnection();
                OdbcDataAdapter adapter;
                string cs = "DRIVER={IBM INFORMIX ODBC DRIVER (64-bit)};  " +
                "HOST=127.0.0.1; " +
                "SERVER=lo_informix1410;" +
                "DATABASE=" +
                 lstDatabases[i]+";"+
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

        protected void ListIndexes() {
            string cmd = "select constrname from sysconstraints;";
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

        protected void ListFunctions() {
            string cmd = "select procname from sysprocedures;";
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

        protected void ListTriggers()
        {
            string cmd = "select trigname from systriggers";
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

        private void CloseConnection(object sender, EventArgs e) {
             MenuTreeView.Nodes[0].Nodes[0].Nodes.Clear();            
            connected = false;
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
    }
}

//string cs = "FileDsn =C:\\informixdb.dsn; UID=informix; PWD=informix1;";
// string cs = "DRIVER=IBM INFORMIX ODBC DRIVER (64-bit):9089; host=127.0.0.1; database=prueba; UID=informix; PWD=informix1";
// String cs = "DRIVER=IBM INFORMIX ODBC DRIVER (64-bit); DATABASE = sysmaster; HOST = 127.0.0.1; SERVER = lo_informix141; SERVICE = lo_informix1410; PROTOCOL = olsoctcp; CLIENT_LOCALE = en_US.CP1252; DB_LOCALE = en_US.819; UID=informix; PWD=informix1";
//  String cs = "DRIVER=IBM INFORMIX ODBC DRIVER (64-bit); DATABASE = sysmaster; HOST = 127.0.0.1; SERVER = lo_informix141; SERVICE = lo_informix1410; PROTOCOL = olsoctcp; CLIENT_LOCALE = en_US.CP1252; DB_LOCALE = en_US.819; ";
//String cs = "Host= 127.0.0.1; Service=1492; Server=lo_informix1410; Database=prueba; Protocol=olsoctcp; UID=informix; PWD=informix1 ";

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
        */
