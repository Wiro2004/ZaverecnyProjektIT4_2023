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
    public partial class AdminRolesControl : Form
    {
        SqlRepository sqlRepository;
        public AdminRolesControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvRoles.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                lvRoles.Items.Add(new ListViewItem(new string[] { role.Name, role.Id.ToString() }));
            }
        }

        private void AdminRolesControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdminRoleEdit_Click(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count > 0)
            {
                AdminEditRole adminEditRole = new AdminEditRole(Convert.ToInt32(lvRoles.SelectedItems[0].SubItems[1].Text), this);
                adminEditRole.ShowDialog();
            }
        }

        private void btnAdminRoleAdd_Click(object sender, EventArgs e)
        {
            AdminAddRole adminAddRole = new AdminAddRole(this);
            adminAddRole.ShowDialog();
        }

        private void btnAdminRoleDelete_Click(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteRole(Convert.ToInt32(lvRoles.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("");
            }
        }
    }
}
