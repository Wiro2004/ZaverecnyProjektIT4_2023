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
    public partial class AdminControlHours : Form
    {
        SqlRepository sqlRepository;
        public AdminControlHours()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
        public void LoadData()
        {
            lvHours.Items.Clear();
            var hours = sqlRepository.GetHours();
            foreach (var hour in hours)
            {
                lvHours.Items.Add(new ListViewItem(new string[] { hour.Name, hour.Hours, hour.Id.ToString() }));
            }
        }

        private void AdminControlContract_Load(object sender, EventArgs e)
        {
            lvHours.Items.Clear();
            var hours = sqlRepository.GetHours();
            foreach (var hour in hours)
            {
                lvHours.Items.Add(new ListViewItem(new string[] { hour.Name, hour.Hours, hour.Id.ToString() }));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvHours.SelectedItems.Count > 0)
            {
                AdminEditHours adminEditHours = new AdminEditHours(Convert.ToInt32(lvHours.SelectedItems[0].SubItems[2].Text));
                adminEditHours.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nebylo nic vybráno.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddHours adminAddHours = new AdminAddHours(this);
            adminAddHours.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvHours.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteHours(Convert.ToInt32(lvHours.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nevybral jste žádnou zakázku!");
            }
        }
    }
}
