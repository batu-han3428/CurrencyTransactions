using CurrencyTransactions;
using dövizAlimSatim.DTO.resetPassword;
using dövizAlimSatim.Methods;
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
    public partial class ResetPassword : Form
    {
        private resetPassword resetPassword;
        private int sayac = 301;
        private resetPasswordResponce1 resetPasswordMail;
        private string mailAdress;

        public ResetPassword()
        {
            InitializeComponent();
            resetPassword = new resetPassword();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            Close();
        }

        private async void btnpush_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";

            if (txtmail.Text == "")
            {
                lblwarning.Text = "● Mail Alanı Boş Geçilemez..";
            }
            else
            {
                
                resetPassword.mail = txtmail.Text;
                resetPassword.resetCode = createResetCode();
                resetPassword.sendingDate = currentDate();

                btnpush.Enabled = false;

                var result = await Api<resetPassword>.pushDataAsync("https://localhost:44391/api/Account/resetPassword", resetPassword);

                resetPasswordMail = Json_Convert<resetPasswordResponce1>.deserializeProcess(Api<resetPasswordResponce1>.apiFormat(result));

                if (resetPasswordMail.mail == 0)
                {
                    btnpush.Enabled = true;
                    lblwarning.Text = "● Mail adresi kayıtlı değil..";
                }
                else
                {
                    timer1.Enabled = true;

                    if (resetPasswordMail.mail == 1 || resetPasswordMail.mail == 3)
                    {
                        StringBuilder mailbuilder = new StringBuilder();
                        mailbuilder = mailContent(mailbuilder);

                        EmailHelper helper = new EmailHelper();
                        bool isSend = helper.SendEmail(txtmail.Text, mailbuilder.ToString());

                        if (isSend)
                        {
                            mailAdress = txtmail.Text;
                            btnnewpassword.Enabled = true;
                            txtresetcode.Enabled = true;
                            lblwarning.Text = "● Sıfırlama kodu mail adresinize gönderildi..";
                        }
                        else {
                            timer1.Enabled = false;
                            MessageBox.Show("Mail gönderilemedi");
                        }
                        
                    }
                    else if (resetPasswordMail.mail == 2)
                    {
                        btnnewpassword.Enabled = true;
                        txtresetcode.Enabled = true;
                        lblwarning.Text = "● 5dk. dolmadan yeni kod alamazsınız..";
                    }
                } 
            }
        }

        private int createResetCode()
        {
            Random rastgele = new Random();

            return rastgele.Next(100000, 1000000);
        }

        private DateTime currentDate()
        {
            return DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lbltime.Visible = true;
            lbltime.Text = "● "+sayac+" saniye";
            if (sayac <= 0)
            {
                lbltime.Visible = false;
                btnpush.Enabled = true;
                sayac = 301;
                timer1.Enabled = false;
            }
        }

        private void grpresetpassword_Enter(object sender, EventArgs e)
        {

        }

        private void btnnewpassword_Click(object sender, EventArgs e)
        {
            lblwarning.Text = "";

            if (txtresetcode.Text != "")
            {
                if (txtresetcode.Text == resetPasswordMail.resetCode.ToString())
                {
                    NewPassword frm = new NewPassword();
                    frm.userMail = mailAdress;
                    frm.Show();
                    Close();                  
                }
            }
            else
            {
                lblwarning.Text = "● Kod alanı boş geçilemez..";
            }
        }

        private StringBuilder mailContent(StringBuilder mailbuilder)
        {
            
            mailbuilder.Append("<html>");
            mailbuilder.Append("<head>");
            mailbuilder.Append("<meta charset=" + "utf-8" + "/>");
            mailbuilder.Append("<title>Şifre Sıfırlama</title>");
            mailbuilder.Append("</head>");
            mailbuilder.Append("<body>");
            mailbuilder.Append("Aşağıdaki kod ile şifrenizi sıfırlaya bilirsiniz.");
            mailbuilder.Append($"\n\n<b>Sıfırlama kodu: {resetPasswordMail.resetCode}</b>");
            mailbuilder.Append("</body>");
            mailbuilder.Append("</html>");

            return mailbuilder;
        }
    }
}
