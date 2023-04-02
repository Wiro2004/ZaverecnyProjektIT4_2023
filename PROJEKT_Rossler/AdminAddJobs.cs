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
    public partial class AdminAddJobs: Form
    {
        SqlRepository sqlRepository;
        public AdminControlJobs AdminControlHours { get; set; }
        public AdminAddJobs(AdminControlJobs adminControlJobs)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminControlJobs = adminControlJobs;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbPopis.Text != "")
            {
                sqlRepository.AddEmployee(tbPopis.Text);
                AdminControlJobs.LoadData();
                Close();
            }
        }
    }
}