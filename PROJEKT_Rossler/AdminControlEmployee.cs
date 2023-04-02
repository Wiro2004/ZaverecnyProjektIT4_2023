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
    public partial class AdminControlEmployee : Form
    {
        SqlRepository sqlRepository;
        public AdminControlEmployee()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            var employees = sqlRepository.GetEmployees();
            listViewControlEmployee.Items.Clear();
            foreach (var employee in employees)
            {
                listViewControlEmployee.Items.Add(new ListViewItem(new string[] { employee.FirstName, employee.LastName, employee.IdEmployee.ToString(), Convert.ToString(employee.BirthDate.ToString("d")), employee.Email.ToString(), string.Format("{0:### ### ###}", long.Parse(employee.Phone)) }));
            }
        }

        private void AdminEmployeesControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewControlEmployee.SelectedItems.Count > 0)
            {
                AdminEditEmployee adminEditEmployee = new AdminEditEmployee(Convert.ToInt32(listViewControlEmployee.SelectedItems[0].SubItems[2].Text), this);
                adminEditEmployee.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddEmployee adminAddEmployee = new AdminAddEmployee(this);
            adminAddEmployee.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewControlEmployee.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteEmployee(Convert.ToInt32(listViewControlEmployee.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nebylo nic vybráno");
            }
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewControlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
