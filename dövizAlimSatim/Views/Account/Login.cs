using dövizAlimSatim.DTO.Login;
using System;
using System.Data;
using System.Windows.Forms;
using RestSharp;
using CurrencyTransactions;
using System.Text.Json;
using System.Web.ModelBinding;
using dövizAlimSatim.Methods;
using dövizAlimSatim.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace dövizAlimSatim.Views.Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btngiris_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";
           
            if (txtmail.Text == "" && txtpassword.Text == "")
            {
                lblwarning.Text = "● Mail Alanı Boş Geçilemez..\n● Parola Alanı Boş Geçilemez..";
            }else if (txtmail.Text == "")
            {
                lblwarning.Text = "● Mail Alanı Boş Geçilemez..";
            }else if (txtpassword.Text == "")
            {
                lblwarning.Text = "● Parola Alanı Boş Geçilemez..";
            }
            else
            {
                SHA1 sha = new SHA1CryptoServiceProvider();

                LoginDTO user = new LoginDTO();
                user.Mail = txtmail.Text;               
                user.Password = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtpassword.Text)));

                var result = await Api<LoginDTO>.pushDataAsync("https://localhost:44391/api/Account/login", user);           
                if (result == "\"Mail veya Parola hatalı\"")
                {
                    lblwarning.Text = "";
                    lblwarning.Text = "Mail veya Parola hatalı";
                }
                else
                {
                    var loginUser = Json_Convert<User>.deserializeProcess(Api<User>.apiFormat(result));

                    Index frm = new Index();
                    frm.user.id = loginUser.id;
                    frm.user.ad = loginUser.ad;
                    frm.user.soyad = loginUser.soyad;
                    frm.user.mail = loginUser.mail;
                    frm.user.parola = loginUser.parola;
                    frm.user.kayitTarihi = loginUser.kayitTarihi;
                    frm.user.tc = loginUser.tc;
                    frm.Show();
                    Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Index frm = new Index();
            frm.Show();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword frm = new ResetPassword();
            frm.Show();
            Close();
        }
    }
}
