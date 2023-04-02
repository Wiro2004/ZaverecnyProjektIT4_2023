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
    public partial class MainAdmin : Form
    {
        private User User { get; set; }

        private new Form Parent { get; set; }
        public MainAdmin(User user, Form form)
        {
            InitializeComponent();
            User = user;
            Parent = form;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdminControlUser adminControlUser = new AdminControlUser();
            adminControlUser.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminControlEmployee adminControlEmployee = new AdminControlEmployee();
            adminControlEmployee.ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            AdminControlContract adminControlContract = new AdminControlContract();
            adminControlContract.ShowDialog();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            AdminControlJobs adminControlJobs = new AdminControlJobs();
            adminControlJobs.ShowDialog();
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            AdminControlHours adminControlHours = new AdminControlHours();
            adminControlHours.ShowDialog();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            AdminControlHours adminControlHours = new AdminControlHours();
            adminControlHours.ShowDialog();
        }
    }
}
