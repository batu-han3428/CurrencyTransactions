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

namespace dövizAlimSatim.Views.Wallet
{
    public partial class Wallet : Form
    {
        public Wallet()
        {
            InitializeComponent();
        }

        private void pctrbxunlogin_Click(object sender, EventArgs e)
        {
            Index frm = new Index();
            frm.Show();
            Close();
        }
    }
}
