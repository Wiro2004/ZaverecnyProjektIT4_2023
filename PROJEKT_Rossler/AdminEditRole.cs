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
    public partial class AdminEditRole : Form
    {
        private int v;
        private AdminRolesControl adminRolesControl;

        public AdminEditRole()
        {
            InitializeComponent();
        }

        public AdminEditRole(int v, AdminRolesControl adminRolesControl)
        {
            this.v = v;
            this.adminRolesControl = adminRolesControl;
        }
    }
}
