using dövizAlimSatim.DTO;
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
            timer1_Tick(sender, e);
            timer1.Enabled = true;
            timerInterval(40000);
        }
      
        private async void timer1_Tick(object sender, EventArgs e)
        {
            var result = await Api<Doviz>.pullDataAsync("https://cancaliskan-doviz-api.herokuapp.com/");

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
        
        private void labelsDataTransfer(Doviz result)
        {
            lbldolar.Text = result.Dollar.SellingPrice+"TL";
            lbleuro.Text = result.Euro.SellingPrice+"TL";
            lblaltin.Text = result.GramGold.SellingPrice+"TL";
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }
    }
}
