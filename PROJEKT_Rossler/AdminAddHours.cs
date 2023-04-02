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
    public partial class AdminAddHours : Form
    {
        private AdminControlHours adminControlHours;

        public AdminAddHours()
        {
            InitializeComponent();
        }

        public AdminAddHours(AdminControlHours adminControlHours)
        {
            this.adminControlHours = adminControlHours;
        }
    }
}
