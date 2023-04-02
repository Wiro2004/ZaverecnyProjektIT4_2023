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
    public partial class AdminAddUser : Form
    {
        SqlRepository sqlRepository;

        private new AdminControlUser ParentForm { get; set; }

        public AdminAddUser(AdminControlUser parent)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            ParentForm = parent;
        }

    

        private void AdminAddUser_Load(object sender, EventArgs e)
        {
            ComboBoxEmployee.Items.Clear();
            var employees = sqlRepository.GetEmployees();
            foreach (var employee in employees)
            {
                if (!sqlRepository.IsUsered(employee.IdEmployee))
                {
                    ComboBoxEmployee.Items.Add(employee.FirstName + " " + employee.LastName + " - " + employee.IdEmployee);
                }
            }
            ComboBoxRole.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
            {
                ComboBoxRole.Items.Add(role.Name);
            }
        }

        private void btnAdminEditOK_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != null && ComboBoxEmployee.Text != null && ComboBoxRole.Text != null)
            {
                var idEmployee = ComboBoxEmployee.Text.Split('-');
                var user = new User(tbUserName.Text);
                var role = sqlRepository.GetRole(ComboBoxRole.Text);
                sqlRepository.AddUser(user.UserName, Convert.ToInt32(idEmployee[1].Trim()), role.Id, user.Password);
                ParentForm.LoadData();
                Close();
                MessageBox.Show("Uživatel přidán");
            }
            else
            {
                MessageBox.Show("");
            }

        }
    }
}
