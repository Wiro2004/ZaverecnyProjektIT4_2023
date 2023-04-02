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
    public partial class AdminEditJobs : Form
    {
        private int v;
        private AdminControlJobs adminControlJobs;

        public AdminEditJobs()
        {
            InitializeComponent();
        }

        public AdminEditJobs(int v, AdminControlJobs adminControlJobs)
        {
            this.v = v;
            this.adminControlJobs = adminControlJobs;
        }
    }
}
