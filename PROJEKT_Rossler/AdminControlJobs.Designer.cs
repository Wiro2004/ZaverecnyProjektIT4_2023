namespace PROJEKT_Rossler
{
    partial class AdminControlJobs
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
            this.lvRoles = new System.Windows.Forms.ListView();
            this.Column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRoles
            // 
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column,
            this.Column0});
            this.lvRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvRoles.FullRowSelect = true;
            this.lvRoles.GridLines = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(0, 0);
            this.lvRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(334, 450);
            this.lvRoles.TabIndex = 2;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // Column0
            // 
            this.Column0.Text = "Popis";
            this.Column0.Width = 100;
            // 
            // Column
            // 
            this.Column.Text = "Id";
            this.Column.Width = 40;
            // 
            // AdminControlJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.lvRoles);
            this.Name = "AdminControlJobs";
            this.Text = "AdminControlJobs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader Column0;
        private System.Windows.Forms.ColumnHeader Column;
    }
}