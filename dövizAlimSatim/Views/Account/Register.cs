using CurrencyTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dövizAlimSatim.Views.Account
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void pcbxback_Click(object sender, EventArgs e)
        {
            Index frm = new Index();
            frm.Show();
            this.Close();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
           
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }
    }
}
