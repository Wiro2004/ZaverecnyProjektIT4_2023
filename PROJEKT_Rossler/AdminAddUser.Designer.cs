namespace PROJEKT_Rossler
{
    partial class AdminAddUser
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.ComboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 71);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(209, 22);
            this.tbUserName.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(298, 341);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(173, 49);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Přidat";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(295, 74);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Uživatelské jméno";
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(12, 145);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(209, 24);
            this.ComboBoxEmployee.TabIndex = 3;
            // 
            // ComboBoxRole
            // 
            this.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.Location = new System.Drawing.Point(12, 229);
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(209, 24);
            this.ComboBoxRole.TabIndex = 4;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(295, 148);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(89, 16);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "Zaměstnanec";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(295, 232);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            // 
            // AdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 402);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.ComboBoxEmployee);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbUserName);
            this.Name = "AdminAddUser";
            this.Text = "AdminAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblRole;
    }
}