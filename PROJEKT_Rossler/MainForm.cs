﻿using System;
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
    public partial class MainForm : Form
    {
        private object id;
        private Login login;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(object id, Login login)
        {
            this.id = id;
            this.login = login;
        }
    }
}
