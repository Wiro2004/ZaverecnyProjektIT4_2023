namespace PROJEKT_Rossler
{
    partial class AdminAddJobs
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
            this.tbPopis = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblJobs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPopis
            // 
            this.tbPopis.Location = new System.Drawing.Point(57, 84);
            this.tbPopis.MaximumSize = new System.Drawing.Size(300, 100);
            this.tbPopis.Name = "tbPopis";
            this.tbPopis.Size = new System.Drawing.Size(205, 22);
            this.tbPopis.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Location = new System.Drawing.Point(121, 35);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(80, 16);
            this.lblJobs.TabIndex = 4;
            this.lblJobs.Text = "Popis práce";
            // 
            // AdminAddJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 240);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPopis);
            this.Name = "AdminAddJobs";
            this.Text = "AdminAddJobs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPopis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblJobs;
    }
}