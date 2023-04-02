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
    public partial class AdminControlContract : Form
    {
        SqlRepository sqlRepository;
        public AdminControlContract()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
        public void LoadData()
        {
            lvContract.Items.Clear();
            var contracts = sqlRepository.GetContracts();
            foreach (var contract in contracts)
            {
                lvContract.Items.Add(new ListViewItem(new string[] { contract.Name, contract.Popis, contract.Id.ToString() }));
            }
        }

        private void AdminControlContract_Load(object sender, EventArgs e)
        {
            lvContract.Items.Clear();
            var contracts = sqlRepository.GetContracts();
            foreach (var contract in contracts)
            {
                lvContract.Items.Add(new ListViewItem(new string[] { contract.Name, contract.Popis, contract.Id.ToString() }));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvContract.SelectedItems.Count > 0)
            {
                AdminEditContract adminEditContract = new AdminEditContract(Convert.ToInt32(lvContract.SelectedItems[0].SubItems[2].Text));
                adminEditContract.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nebylo nic vybráno.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminAddContract adminAddContract = new AdminAddContract(this);
            adminAddContract.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvContract.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteContract(Convert.ToInt32(lvContract.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
            {
                MessageBox.Show("Nevybral jste žádnou zakázku!");
            }
        }
    }
}
