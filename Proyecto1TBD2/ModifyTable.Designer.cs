namespace Proyecto1TBD2
{
    partial class ModifyTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DatosTable = new System.Windows.Forms.DataGridView();
            this.act = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Val = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosTable
            // 
            this.DatosTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DatosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.act,
            this.Val});
            this.DatosTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosTable.Location = new System.Drawing.Point(0, 0);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.Size = new System.Drawing.Size(554, 269);
            this.DatosTable.TabIndex = 2;
            this.DatosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosTable_CellContentClick);
            // 
            // act
            // 
            this.act.HeaderText = "Accion";
            this.act.Items.AddRange(new object[] {
            "Modif. tipo col",
            "Renombrar col",
            "Agregar col",
            "Eliminar col"});
            this.act.Name = "act";
            // 
            // Val
            // 
            this.Val.HeaderText = "Nuevo Valor";
            this.Val.Items.AddRange(new object[] {
            "Int",
            "char(20)",
            "boolean",
            "decimal",
            "float"});
            this.Val.Name = "Val";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosTable);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 269);
            this.panel1.TabIndex = 3;
            // 
            // ModifyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(582, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "ModifyTable";
            this.Text = "ModifyTable";
            this.Load += new System.EventHandler(this.ModifyTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DatosTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn act;
        private System.Windows.Forms.DataGridViewComboBoxColumn Val;
    }
}