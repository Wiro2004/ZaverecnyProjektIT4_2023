namespace PROJEKT_Rossler
{
    partial class Login
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblHeslo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(47, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 22);
            this.tbName.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(46, 117);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(172, 22);
            this.tbPass.TabIndex = 1;
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(46, 15);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(48, 16);
            this.lblJmeno.TabIndex = 2;
            this.lblJmeno.Text = "Jmeno";
            // 
            // lblHeslo
            // 
            this.lblHeslo.AutoSize = true;
            this.lblHeslo.Location = new System.Drawing.Point(46, 98);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(43, 16);
            this.lblHeslo.TabIndex = 3;
            this.lblHeslo.Text = "Heslo";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(49, 184);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Přihlásit";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 257);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblHeslo);
            this.Controls.Add(this.lblJmeno);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblHeslo;
        private System.Windows.Forms.Button btnLogin;
    }
}