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
    public partial class Login : Form
    {
        SqlRepository sqlRepository;
        public Login()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbName.Text != " " && tbPass.Text != " ")
            {
                User user = sqlRepository.GetUser(tbName.Text);
                if (user != null)
                {
                    Role role = sqlRepository.GetRole(user.Role);
                    if (tbPass.Text == user.Password.ToString())
                    {
                        if (role.Name == "Admin")
                        {
                            MainAdmin mainAdmin = new MainAdmin(id, this);
                            mainAdmin.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MainForm mainForm = new MainForm(id, this);
                            mainForm.ShowDialog();
                            this.Hide();
                        }

                    }


                    else
                    {
                        MessageBox.Show("Špatné heslo");
                    }
                }
                else
                {
                    MessageBox.Show("Uživatel neexistuje");
                }
            }
            else
            {
                MessageBox.Show("Nevyplněno");
            }

        }
    }
}
