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
    public partial class EmployForm : Form
    {
        SqlRepository sqlRepository;
        public EmployForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektRossler;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void EmployForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var Employees = sqlRepository.GetEmployees();

            foreach (var Employee in Employees)
            {
                listView1.Items.Add(new ListViewItem(new string[] { Employee.IdEmployee.ToString(), Employee.FirstName.ToString(), Employee.LastName.ToString(), Employee.BirthDate.ToString(), Employee.Email.ToString(), Employee.Phone.ToString() }));
            }
            
        }
    }
}
