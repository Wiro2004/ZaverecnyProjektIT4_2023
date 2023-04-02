namespace PROJEKT_Rossler
{
    partial class AdminUsersControl
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
            this.lvControl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvControl.FullRowSelect = true;
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(0, 0);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(416, 450);
            this.lvControl.TabIndex = 0;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Uživ. Jméno";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Role";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(513, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(216, 69);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Přidat";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(513, 178);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(216, 69);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(513, 300);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(216, 69);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Odstranit";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // AdminControlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lvControl);
            this.Name = "AdminControlUser";
            this.Text = "AdminControlUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}