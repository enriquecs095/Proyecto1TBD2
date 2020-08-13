namespace Proyecto1TBD2
{
    partial class AddTrigger
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
            this.lstaction = new System.Windows.Forms.ComboBox();
            this.lblaction = new System.Windows.Forms.Label();
            this.Commands = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fpName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstaction);
            this.panel1.Controls.Add(this.lblaction);
            this.panel1.Controls.Add(this.Commands);
            this.panel1.Controls.Add(this.cmdAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fpName);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 276);
            this.panel1.TabIndex = 1;
            // 
            // lstaction
            // 
            this.lstaction.FormattingEnabled = true;
            this.lstaction.Items.AddRange(new object[] {
            "DELETE",
            "INSERT",
            "UPDATE"});
            this.lstaction.Location = new System.Drawing.Point(90, 61);
            this.lstaction.Name = "lstaction";
            this.lstaction.Size = new System.Drawing.Size(149, 21);
            this.lstaction.TabIndex = 13;
            this.lstaction.SelectedIndexChanged += new System.EventHandler(this.lstaction_SelectedIndexChanged);
            // 
            // lblaction
            // 
            this.lblaction.AutoSize = true;
            this.lblaction.Location = new System.Drawing.Point(13, 64);
            this.lblaction.Name = "lblaction";
            this.lblaction.Size = new System.Drawing.Size(44, 13);
            this.lblaction.TabIndex = 12;
            this.lblaction.Text = "Evento:";
            // 
            // Commands
            // 
            this.Commands.Location = new System.Drawing.Point(36, 88);
            this.Commands.Multiline = true;
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(334, 172);
            this.Commands.TabIndex = 7;
            this.Commands.TextChanged += new System.EventHandler(this.Commands_TextChanged);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(259, 20);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(95, 23);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre: ";
            // 
            // fpName
            // 
            this.fpName.Location = new System.Drawing.Point(90, 23);
            this.fpName.Name = "fpName";
            this.fpName.Size = new System.Drawing.Size(149, 20);
            this.fpName.TabIndex = 4;
            // 
            // AddTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(454, 326);
            this.Controls.Add(this.panel1);
            this.Name = "AddTrigger";
            this.Text = "AddTrigger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox lstaction;
        private System.Windows.Forms.Label lblaction;
        private System.Windows.Forms.TextBox Commands;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fpName;
    }
}