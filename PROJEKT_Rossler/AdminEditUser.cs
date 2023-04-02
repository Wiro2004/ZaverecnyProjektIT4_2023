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
    public partial class AdminEditUser : Form
    {
        private int id;
        private AdminUsersControl adminUsersControl;

        public AdminEditUser()
        {
            InitializeComponent();
        }

        public AdminEditUser(int id, AdminUsersControl adminUsersControl)
        {
            this.id = id;
            this.adminUsersControl = adminUsersControl;
        }
    }
}
