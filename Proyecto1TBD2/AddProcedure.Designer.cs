namespace Proyecto1TBD2
{
    partial class AddProcedure
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstVar = new System.Windows.Forms.ComboBox();
            this.lblretorna = new System.Windows.Forms.Label();
            this.typeName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Commands = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fpName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstVar);
            this.panel1.Controls.Add(this.lblretorna);
            this.panel1.Controls.Add(this.typeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Commands);
            this.panel1.Controls.Add(this.cmdAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fpName);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 297);
            this.panel1.TabIndex = 0;
            // 
            // lstVar
            // 
            this.lstVar.FormattingEnabled = true;
            this.lstVar.Items.AddRange(new object[] {
            "Int",
            "char(20)",
            "boolean",
            "decimal",
            "float"});
            this.lstVar.Location = new System.Drawing.Point(310, 76);
            this.lstVar.Name = "lstVar";
            this.lstVar.Size = new System.Drawing.Size(95, 21);
            this.lstVar.TabIndex = 11;
            this.lstVar.Visible = false;
            this.lstVar.SelectedIndexChanged += new System.EventHandler(this.lstVar_SelectedIndexChanged);
            // 
            // lblretorna
            // 
            this.lblretorna.AutoSize = true;
            this.lblretorna.Location = new System.Drawing.Point(256, 79);
            this.lblretorna.Name = "lblretorna";
            this.lblretorna.Size = new System.Drawing.Size(48, 13);
            this.lblretorna.TabIndex = 10;
            this.lblretorna.Text = "Retorna:";
            this.lblretorna.Visible = false;
            // 
            // typeName
            // 
            this.typeName.FormattingEnabled = true;
            this.typeName.Items.AddRange(new object[] {
            "Procedimiento",
            "Funcion"});
            this.typeName.Location = new System.Drawing.Point(90, 79);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(149, 21);
            this.typeName.TabIndex = 9;
            this.typeName.SelectedIndexChanged += new System.EventHandler(this.typeName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // Commands
            // 
            this.Commands.Location = new System.Drawing.Point(36, 110);
            this.Commands.Multiline = true;
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(334, 172);
            this.Commands.TabIndex = 7;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(310, 38);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(95, 23);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre: ";
            // 
            // fpName
            // 
            this.fpName.Location = new System.Drawing.Point(90, 45);
            this.fpName.Name = "fpName";
            this.fpName.Size = new System.Drawing.Size(149, 20);
            this.fpName.TabIndex = 4;
            // 
            // AddProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(441, 333);
            this.Controls.Add(this.panel1);
            this.Name = "AddProcedure";
            this.Text = "Actions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Commands;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fpName;
        private System.Windows.Forms.ComboBox typeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstVar;
        private System.Windows.Forms.Label lblretorna;
    }
}