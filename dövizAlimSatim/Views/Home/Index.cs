using dövizAlimSatim.DTO;
using dövizAlimSatim.DTO.yeniDoviz;
using dövizAlimSatim.Methods;
using dövizAlimSatim.ViewModels;
using dövizAlimSatim.Views.Account;
using dövizAlimSatim.Views.Wallet;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyTransactions
{
    public partial class Index : Form
    {
        public User user;
        public balance balance;
        public currencyTransactions currencyTransactions;
        public movements movements;
        public Index()
        {
            user = new User();
            balance = new balance();
            currencyTransactions = new currencyTransactions();
            movements = new movements();
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            loginCheck(user);
            timer1_Tick(sender, e);
            timer1.Enabled = true;
            timerInterval(40000);
        }
      
        private async void timer1_Tick(object sender, EventArgs e)
        {
            var result = await Api<yeniDoviz>.pullDataAsync("https://finans.truncgil.com/v3/today.json");

            labelsDataTransfer(result);
        }
     
        private void timerInterval(int interval) {        
            timer1.Interval = interval;
        }
        
        private void labelsDataTransfer(yeniDoviz result)
        {
            lbldolar.Text = result.USD.Selling+"TL";
            lbleuro.Text = result.EUR.Selling+"TL";
            lblsterlin.Text = result.GBP.Selling+"TL";
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            Hide();
        }

        private void loginCheck(User user)
        {
            if (user.id != 0)
            {
                embedData(user);

                grptrade.Visible = true;
                pctrbxunlogin.Visible = true;
                labell.Visible = true;
                lblwelcome.Visible = true;
                btngiris.Visible = false;
                lblor.Visible = false;
                linkLabel1.Visible = false;           
            }
            else
            {
                grptrade.Visible = false;
                pctrbxunlogin.Visible = false;
                labell.Visible = false;
                lblwelcome.Visible = false;
                btngiris.Visible = true;
                lblor.Visible = true;
                linkLabel1.Visible = true;
            }
        }

        private void pctrbxunlogin_Click(object sender, EventArgs e)
        {
            user = new User();
            loginCheck(user);
        }

        private void embedData(User user)
        {
            lblwelcome.Text = user.ad;
            lblbalance.Text = user.balance.amount + "TL";
        }

        private void btnwallet_Click(object sender, EventArgs e)
        {
            map(user);

            Wallet frm = new Wallet();
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
            Hide();
        }

        private void map(User loginUser)
        {
            balance.userID = loginUser.balance.userID;
            balance.amount = loginUser.balance.amount;


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
    }
}
