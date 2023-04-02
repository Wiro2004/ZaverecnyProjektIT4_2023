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
    public partial class AdminEditHours : Form
    {
        private int v;

        public AdminEditHours()
        {
            InitializeComponent();
        }

        public AdminEditHours(int v)
        {
            this.v = v;
        }
    }
}
