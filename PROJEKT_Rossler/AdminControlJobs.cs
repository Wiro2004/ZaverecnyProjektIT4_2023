using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_Rossler
{
    public partial class AdminControlJobs : Form
    {
        SqlRepository sqlRepository;
        public AdminControlJobs()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminControlJobs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var jobs = sqlRepository.GetJobs();
            lvControl.Items.Clear();
            foreach (var jobs in jobs)
            {
                lvControl.Items.Add(new ListViewItem(new string[] {jobs.Id.ToString(), jobs.Popis }));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                AdminEditJobs adminWorkTypeControlEdit = new AdminEditJobs(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[1].Text), this);
                adminWorkTypeControlEdit.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddJobs adminAddJobs = new AdminAddJobs(this);
            adminAddJobs.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteWorkType(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
        }
    }
}
