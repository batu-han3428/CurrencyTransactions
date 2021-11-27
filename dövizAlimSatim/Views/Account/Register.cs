using CurrencyTransactions;
using dövizAlimSatim.DTO.Register;
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

namespace dövizAlimSatim.Views.Account
{
    public partial class Register : Form
    {
        private RegisterDTO register;

        public Register()
        {
            InitializeComponent();
            register = new RegisterDTO();
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

        private async void btnkayit_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";
            string name = "";

            name = inputDataControl(name);


            if (name == "")
            {
                if (Parola.Text == TParola.Text)
                {
                    SHA1 sha = new SHA1CryptoServiceProvider();

                    register.parola = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(Parola.Text)));
                    register.ad = Ad.Text;
                    register.soyad = Soyad.Text;
                    register.mail = Mail.Text;
                    register.tc = TC.Text;
                    

                    var result = await Api<RegisterDTO>.pushDataAsync("https://localhost:44391/api/Account/register", register);  

                    var loginUser = Json_Convert<KayitliHesap>.deserializeProcess(Api<KayitliHesap>.apiFormat(result));

                    if (loginUser.mail == 1 && loginUser.tc == 1)
                    {
                        lblwarning.Text = "Mail ve Tc Zaten Kayıtlı..";
                    }else if (loginUser.mail == 1)
                    {
                        lblwarning.Text = "Mail Adresi Kayıtlı..";
                    }else if (loginUser.tc == 1)
                    {
                        lblwarning.Text = "Tc Adresi Kayıtlı..";
                    }else
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        Index frm = new Index();
                        frm.Show();
                        Close();
                    }
                }
                else
                {
                    lblwarning.Text = "● Parola - TParola Alanı Aynı Olmak Zorunda..";
                }
            }

        }

        private string inputDataControl(string name)
        {
            foreach (var item in grpregister.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == "")
                    {
                        name = ((TextBox)item).Name;
                        lblwarning.Text += "● '" + name + "' Alanı Boş Geçilemez..\n";
                    }
                }
            }

            return name;
        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }
    }
}
