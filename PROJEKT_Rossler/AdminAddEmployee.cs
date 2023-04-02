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
    public partial class AdminAddEmployee : Form
    {
        SqlRepository sqlRepository;
        public AdminControlEmployee AdminControlEmployee { get; set; }
        public AdminAddEmployee(AdminControlEmployee adminControlEmployee)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminControlEmployee = adminControlEmployee;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && tbLastName.Text != "" && tbFirstName.Text != "" && tbPhone.Text != "")
            {
                sqlRepository.AddEmployee(tbFirstName.Text, tbLastName.Text, dtpBirthDate.Value, tbEmail.Text, tbPhone.Text);
                AdminControlEmployee.LoadData();
                Close();
            }
        }
    }
}