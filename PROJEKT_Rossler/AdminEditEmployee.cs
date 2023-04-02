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
    public partial class AdminEditEmployee : Form
    {
        private int v;
        private AdminControlEmployee adminControlEmployee;

        public AdminEditEmployee()
        {
            InitializeComponent();
        }

        public AdminEditEmployee(int v, AdminControlEmployee adminControlEmployee)
        {
            this.v = v;
            this.adminControlEmployee = adminControlEmployee;
        }
    }
}
