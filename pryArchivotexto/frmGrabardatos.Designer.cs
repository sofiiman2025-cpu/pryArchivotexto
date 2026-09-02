namespace pryArchivotexto
{
    partial class frmGrabardatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
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
            this.txtGrabar = new System.Windows.Forms.TextBox();
            this.lblGrabar = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.grpGrabar = new System.Windows.Forms.GroupBox();
            this.grpGrabar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGrabar
            // 
            this.txtGrabar.Location = new System.Drawing.Point(110, 38);
            this.txtGrabar.Name = "txtGrabar";
            this.txtGrabar.Size = new System.Drawing.Size(108, 24);
            this.txtGrabar.TabIndex = 0;
            // 
            // lblGrabar
            // 
            this.lblGrabar.AutoSize = true;
            this.lblGrabar.Location = new System.Drawing.Point(8, 41);
            this.lblGrabar.Name = "lblGrabar";
            this.lblGrabar.Size = new System.Drawing.Size(96, 16);
            this.lblGrabar.TabIndex = 1;
            this.lblGrabar.Text = "Datos a grabar";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(143, 92);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // grpGrabar
            // 
            this.grpGrabar.BackColor = System.Drawing.Color.LavenderBlush;
            this.grpGrabar.Controls.Add(this.lblGrabar);
            this.grpGrabar.Controls.Add(this.btnGrabar);
            this.grpGrabar.Controls.Add(this.txtGrabar);
            this.grpGrabar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrabar.Location = new System.Drawing.Point(12, 12);
            this.grpGrabar.Name = "grpGrabar";
            this.grpGrabar.Size = new System.Drawing.Size(267, 150);
            this.grpGrabar.TabIndex = 3;
            this.grpGrabar.TabStop = false;
            this.grpGrabar.Text = ".";
            // 
            // frmGrabardatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(294, 178);
            this.Controls.Add(this.grpGrabar);
            this.Name = "frmGrabardatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGrabardatos_Load);
            this.grpGrabar.ResumeLayout(false);
            this.grpGrabar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrabar;
        private System.Windows.Forms.Label lblGrabar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox grpGrabar;
    }
}

