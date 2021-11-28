using CurrencyTransactions;
using dövizAlimSatim.DTO.Wallet;
using dövizAlimSatim.Methods;
using dövizAlimSatim.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dövizAlimSatim.Views.Wallet
{
    public partial class Wallet : Form
    {
        public WalletDTO wallet;
        public User user;
        public balance balance;
        public currencyTransactions currencyTransactions;
        public movements movements;
        public Wallet()
        {
            user = new User();
            wallet = new WalletDTO();
            balance = new balance();
            currencyTransactions = new currencyTransactions();
            movements = new movements();
            InitializeComponent();
        }

        private void pctrbxunlogin_Click(object sender, EventArgs e)
        {
            map(user);

            Index frm = new Index();
            frm.user.id = user.id;
            frm.user.ad = user.ad;
            frm.user.soyad = user.soyad;
            frm.user.mail = user.mail;
            frm.user.parola = user.parola;
            frm.user.kayitTarihi = user.kayitTarihi;
            frm.user.tc = user.tc;
            frm.user.balance = balance;
            frm.user.balance.movements = movements;
            frm.user.balance.movements.currencyTransactions = currencyTransactions;

            frm.Show();
            Close();
        }

        private void grpwallet_Enter(object sender, EventArgs e)
        {
            lblamound.Text = user.balance.amount+"TL";
            wallet.amount = user.balance.amount;
        }

        private void map(User loginUser)
        {
            balance.userID = loginUser.balance.userID;
            balance.amount = wallet.amount;


            movements.id = loginUser.balance.movements.id;
            movements.userID = loginUser.balance.movements.userID;
            movements.wallet = loginUser.balance.movements.wallet;
            movements.currency = loginUser.balance.movements.currency;
            movements.buySell = loginUser.balance.movements.buySell;
            movements.amount = loginUser.balance.movements.amount;
            movements.date = loginUser.balance.movements.date;


            currencyTransactions.userID = loginUser.balance.movements.currencyTransactions.userID;
            currencyTransactions.dollar = loginUser.balance.movements.currencyTransactions.dollar;
            currencyTransactions.euro = loginUser.balance.movements.currencyTransactions.euro;
            currencyTransactions.pound = loginUser.balance.movements.currencyTransactions.pound;
        }

        private async void btnpush_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";

            if (txtpush.Text == "")
            {
                lblwarning.Text = "● Bu alan boş geçilemez..";
            }
            else
            {
                string veri = lblamound.Text.Substring(0, lblamound.Text.Length - 2);

                wallet.userID = user.id;
                wallet.amount = float.Parse(veri, CultureInfo.InvariantCulture.NumberFormat) + float.Parse(txtpush.Text, CultureInfo.InvariantCulture.NumberFormat);

                var result = await Api<WalletDTO>.pushDataAsync("https://localhost:44391/api/Wallet/wallet", wallet);

                wallet = Json_Convert<WalletDTO>.deserializeProcess(Api<WalletDTO>.apiFormat(result));

                if (wallet != null)
                {                   
                    lblamound.Text = wallet.amount + "TL";
                    txtpush.Text = "";
                    MessageBox.Show("Para yükleme işlemi gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Beklenmeyen bir hata oldu");
                }
            }
        }

        private void txtpush_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpull_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnpull_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";

            if (txtpull.Text == "")
            {
                lblwarning.Text = "● Bu alan boş geçilemez..";
            }else if (txtpull.Text == "0")
            {
                lblwarning.Text = "● Bakiye yetersiz..";
            }
            else
            {
                string veri = lblamound.Text.Substring(0, lblamound.Text.Length - 2);

                if (float.Parse(veri, CultureInfo.InvariantCulture.NumberFormat) < float.Parse(txtpull.Text, CultureInfo.InvariantCulture.NumberFormat))
                {
                    lblwarning.Text = "● Bakiye yetersiz..";
                }
                else { 
                    wallet.userID = user.id;
                    wallet.amount = float.Parse(veri, CultureInfo.InvariantCulture.NumberFormat) - float.Parse(txtpull.Text, CultureInfo.InvariantCulture.NumberFormat);

                    var result = await Api<WalletDTO>.pushDataAsync("https://localhost:44391/api/Wallet/wallet", wallet);

                    wallet = Json_Convert<WalletDTO>.deserializeProcess(Api<WalletDTO>.apiFormat(result));

                    if (wallet != null)
                    {
                        lblamound.Text = wallet.amount + "TL";
                        txtpush.Text = "";
                        MessageBox.Show("Para çekme işlemi gerçekleşti");
                    }
                    else
                    {
                        MessageBox.Show("Beklenmeyen bir hata oldu");
                    }
                }
            }
        }

        private void Wallet_Load(object sender, EventArgs e)
        {

        }
    }
}
