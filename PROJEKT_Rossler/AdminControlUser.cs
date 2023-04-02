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
    public partial class AdminUsersControl : Form
    {
        SqlRepository sqlRepository;

        public AdminUsersControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvControl.Items.Clear();
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.IdEmployee);
                var role = sqlRepository.GetRole(user.Role);
                lvControl.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.UserName, user.Id.ToString(), role.Name.ToString() }));
            }
        }

        private void AdminControlUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvAdminUsersControl.SelectedItems[0].SubItems[2].Text);
            if (lvControl.SelectedItems.Count > 0)
            {
                var id = Convert.ToInt32(lvControl.SelectedItems[0].SubItems[2].Text);
                AdminEditUser adminEditUser = new AdminEditUser(id, this);
                adminEditUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný uživatel!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddUser adminAddUser = new AdminAddUser(this);
            adminAddUser.ShowDialog();
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteUser(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný uživatel!");
            }
        }
    }
}
