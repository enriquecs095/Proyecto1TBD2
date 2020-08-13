namespace Proyecto1TBD2
{
    partial class Inicio
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.MenuTreeView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Files = new System.Windows.Forms.ToolStripSplitButton();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.documentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new System.Data.DataSet();
            this.panelDT = new System.Windows.Forms.Panel();
            this.ListData = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OutputMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListData)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.MenuTreeView);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 512);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(176, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(26, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuTreeView
            // 
            this.MenuTreeView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MenuTreeView.Location = new System.Drawing.Point(0, 3);
            this.MenuTreeView.Name = "MenuTreeView";
            this.MenuTreeView.Size = new System.Drawing.Size(202, 476);
            this.MenuTreeView.TabIndex = 0;
            this.MenuTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 44);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Files,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Files
            // 
            this.Files.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.Files.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(64, 22);
            this.Files.Text = "Archivo";
            this.Files.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.archivoToolStripMenuItem.Text = "Generar Script";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentacionToolStripMenuItem});
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(88, 22);
            this.toolStripSplitButton2.Text = "Informacion";
            // 
            // documentacionToolStripMenuItem
            // 
            this.documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            this.documentacionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.documentacionToolStripMenuItem.Text = "Documentacion";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // panelDT
            // 
            this.panelDT.Controls.Add(this.ListData);
            this.panelDT.Location = new System.Drawing.Point(218, 53);
            this.panelDT.Name = "panelDT";
            this.panelDT.Size = new System.Drawing.Size(603, 353);
            this.panelDT.TabIndex = 2;
            // 
            // ListData
            // 
            this.ListData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListData.Location = new System.Drawing.Point(3, 3);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(595, 342);
            this.ListData.TabIndex = 0;
            this.ListData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListData_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OutputMessage);
            this.panel3.Location = new System.Drawing.Point(221, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 108);
            this.panel3.TabIndex = 3;
            // 
            // OutputMessage
            // 
            this.OutputMessage.AllowDrop = true;
            this.OutputMessage.Enabled = false;
            this.OutputMessage.Location = new System.Drawing.Point(0, 0);
            this.OutputMessage.Multiline = true;
            this.OutputMessage.Name = "OutputMessage";
            this.OutputMessage.Size = new System.Drawing.Size(597, 105);
            this.OutputMessage.TabIndex = 0;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(842, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView MenuTreeView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton Files;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem documentacionToolStripMenuItem;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Panel panelDT;
        private System.Windows.Forms.DataGridView ListData;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox OutputMessage;
        private System.Windows.Forms.Button btnActualizar;
    }

}

