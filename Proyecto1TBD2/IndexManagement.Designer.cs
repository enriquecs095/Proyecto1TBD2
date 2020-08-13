namespace Proyecto1TBD2
{
    partial class IndexManagement
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosTable = new System.Windows.Forms.DataGridView();
            this.indexName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre de la tabla:";
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(25, 34);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(156, 20);
            this.tableName.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(215, 27);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(215, 56);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 3;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosTable);
            this.panel1.Location = new System.Drawing.Point(25, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 193);
            this.panel1.TabIndex = 4;
            // 
            // DatosTable
            // 
            this.DatosTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTable.Location = new System.Drawing.Point(3, 3);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.Size = new System.Drawing.Size(286, 190);
            this.DatosTable.TabIndex = 0;
            // 
            // indexName
            // 
            this.indexName.Location = new System.Drawing.Point(25, 75);
            this.indexName.Name = "indexName";
            this.indexName.Size = new System.Drawing.Size(156, 20);
            this.indexName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el nombre del indice";
            // 
            // IndexManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(350, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indexName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label1);
            this.Name = "IndexManagement";
            this.Text = "IndexManagement";
            this.Load += new System.EventHandler(this.IndexManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosTable;
        private System.Windows.Forms.TextBox indexName;
        private System.Windows.Forms.Label label2;
    }
}