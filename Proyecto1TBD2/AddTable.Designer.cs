namespace Proyecto1TBD2
{
    partial class AddTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosTable = new System.Windows.Forms.DataGridView();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVariable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NotNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ActionAddTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la tabla:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(121, 26);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(158, 20);
            this.tableName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosTable);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 206);
            this.panel1.TabIndex = 3;
            // 
            // DatosTable
            // 
            this.DatosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreC,
            this.TVariable,
            this.NotNull,
            this.PK});
            this.DatosTable.Location = new System.Drawing.Point(3, 0);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.Size = new System.Drawing.Size(529, 204);
            this.DatosTable.TabIndex = 0;
            this.DatosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre";
            this.NombreC.Name = "NombreC";
            // 
            // TVariable
            // 
            this.TVariable.HeaderText = "Variable";
            this.TVariable.Items.AddRange(new object[] {
            "Int",
            "char(20)",
            "boolean",
            "decimal",
            "float"});
            this.TVariable.Name = "TVariable";
            // 
            // NotNull
            // 
            this.NotNull.HeaderText = "Not Null";
            this.NotNull.Name = "NotNull";
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.Name = "PK";
            // 
            // ActionAddTable
            // 
            this.ActionAddTable.Location = new System.Drawing.Point(289, 26);
            this.ActionAddTable.Name = "ActionAddTable";
            this.ActionAddTable.Size = new System.Drawing.Size(75, 23);
            this.ActionAddTable.TabIndex = 4;
            this.ActionAddTable.Text = "Agregar";
            this.ActionAddTable.UseVisualStyleBackColor = true;
            this.ActionAddTable.Click += new System.EventHandler(this.ActionAddTable_Click);
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(615, 287);
            this.Controls.Add(this.ActionAddTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label1);
            this.Name = "AddTable";
            this.Text = "AddTable";
            this.Load += new System.EventHandler(this.AddTable_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosTable;
        private System.Windows.Forms.Button ActionAddTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewComboBoxColumn TVariable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PK;
    }
}