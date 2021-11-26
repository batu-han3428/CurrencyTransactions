using CurrencyTransactions;
using dövizAlimSatim.DTO.Register;
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

        private void btnkayit_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";
            string name = "";

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

            if (name =="")
            {
                if (Parola.Text == TParola.Text)
                {
                    register.ad = Ad.Text;
                    register.soyad = Soyad.Text;
                    register.mail = Mail.Text;
                    register.tc = TC.Text;
                    register.parola = Parola.Text;
                }
                else
                {
                    lblwarning.Text = "● Parola - TParola Alanı Aynı Olmak Zorunda..";
                }
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
           
        }
    }
}
