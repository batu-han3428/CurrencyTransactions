using dövizAlimSatim.DTO.resetPassword;
using dövizAlimSatim.Methods;
using dövizAlimSatim.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CurrencyTransactions;

namespace dövizAlimSatim.Views.Account
{
    public partial class NewPassword : Form
    {
        public string userMail;
        private newPassword user;

        public NewPassword()
        {
            InitializeComponent();
            user = new newPassword();
        }

        private async void btnpush_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";

            if (txtpassword.Text != "" && txtagainpassword.Text != "")
            {
                if (txtpassword.Text == txtagainpassword.Text)
                {
                    SHA1 sha = new SHA1CryptoServiceProvider();

                    user.mail = userMail;
                    user.password = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtpassword.Text)));
     

                    var result = await Api<newPassword>.pushDataAsync("https://localhost:44391/api/Account/newPassword", user);

                    if (result != "")
                    {
                        MessageBox.Show("Şifreniz güncellendi..");
                        Index frm = new Index();
                        frm.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Beklenmedik bir hata oluştu..");
                        Application.Exit();
                    }
                }
                else
                {
                    lblwarning.Text = "● Parola - TParola aynı olmak zorunda..";
                }
            }
            else
            {
                lblwarning.Text = "● Alanlar boş geçilemez..";
            }
        }
    }
}
