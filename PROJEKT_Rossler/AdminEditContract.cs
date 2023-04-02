using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROJEKT_Rossler
{
    public partial class AdminEditContract : Form
    {
        SqlRepository sqlRepository;
        public int IdContract { get; set; }
        public AdminEditContract(int idContract)
        {
            InitializeComponent();
            IdContract = idContract;
            sqlRepository = new SqlRepository();
        }

        private void AdminEditContract_Load(object sender, EventArgs e)
        {
            var contract = sqlRepository.GetContract(IdContract);
            if (contract != null)
            {
                tbPopis.Text = contract.Popis;
                tbName.Text = contract.Name;
            }
        }


    }
}
