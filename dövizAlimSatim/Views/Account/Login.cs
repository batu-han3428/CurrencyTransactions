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
                LoginDTO user = new LoginDTO();
                user.Mail = txtmail.Text;
                user.Password = txtpassword.Text;

                var result = await Api<LoginDTO>.pushDataAsync("https://localhost:44391/api/Account/login", user);           
                if (result == "\"Mail veya Parola hatalı\"")
                {
                    lblwarning.Text = "";
                    lblwarning.Text = "Mail veya Parola hatalı";
                }
                else
                {
                    var loginUser = Json_Convert<User>.deserializeProcess(Api<User>.apiFormat(result));

                   
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Index frm = new Index();
            frm.Show();
            this.Close();
        }
    }
}
