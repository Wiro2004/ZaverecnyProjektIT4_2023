namespace PROJEKT_Rossler
{
    partial class MainAdmin
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnHours = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(39, 34);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(165, 65);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Uživatelé";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(39, 309);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(165, 65);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "Práce";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(324, 34);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(165, 65);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Zaměstnanci";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(324, 155);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(165, 65);
            this.btnContracts.TabIndex = 4;
            this.btnContracts.Text = "Kontrakty";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnHours
            // 
            this.btnHours.Location = new System.Drawing.Point(324, 309);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(165, 65);
            this.btnHours.TabIndex = 5;
            this.btnHours.Text = "Hodiny";
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(39, 172);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(165, 65);
            this.btnRole.TabIndex = 6;
            this.btnRole.Text = "Role";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 415);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnHours);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnUsers);
            this.Name = "MainAdmin";
            this.Text = "Admin Formulář";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnHours;
        private System.Windows.Forms.Button btnRole;
    }
}