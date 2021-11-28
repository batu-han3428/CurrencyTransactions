using dövizAlimSatim.DTO;
using dövizAlimSatim.DTO.yeniDoviz;
using dövizAlimSatim.Methods;
using dövizAlimSatim.ViewModels;
using dövizAlimSatim.Views.Account;
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
        public Index()
        {
            user = new User();
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

        private void labelsCenter()
        {
            foreach (Control item in grpkur.Controls)
            {
                item.Left += 23;
            }
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
            if (user.mail != null)
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
        }
    }
}
