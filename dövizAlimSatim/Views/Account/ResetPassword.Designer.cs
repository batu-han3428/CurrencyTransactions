
namespace dövizAlimSatim.Views.Account
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.grpresetpassword = new System.Windows.Forms.GroupBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnnewpassword = new System.Windows.Forms.Button();
            this.txtresetcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblwarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpush = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpresetpassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpresetpassword
            // 
            this.grpresetpassword.BackColor = System.Drawing.Color.Transparent;
            this.grpresetpassword.Controls.Add(this.lbltime);
            this.grpresetpassword.Controls.Add(this.btnnewpassword);
            this.grpresetpassword.Controls.Add(this.txtresetcode);
            this.grpresetpassword.Controls.Add(this.label3);
            this.grpresetpassword.Controls.Add(this.label2);
            this.grpresetpassword.Controls.Add(this.lblwarning);
            this.grpresetpassword.Controls.Add(this.pictureBox1);
            this.grpresetpassword.Controls.Add(this.btnpush);
            this.grpresetpassword.Controls.Add(this.txtmail);
            this.grpresetpassword.Controls.Add(this.label1);
            this.grpresetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpresetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpresetpassword.ForeColor = System.Drawing.Color.White;
            this.grpresetpassword.Location = new System.Drawing.Point(12, 18);
            this.grpresetpassword.Name = "grpresetpassword";
            this.grpresetpassword.Size = new System.Drawing.Size(401, 512);
            this.grpresetpassword.TabIndex = 13;
            this.grpresetpassword.TabStop = false;
            this.grpresetpassword.Text = "Şifremi Sıfırla";
            this.grpresetpassword.Enter += new System.EventHandler(this.grpresetpassword_Enter);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(23, 96);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 25);
            this.lbltime.TabIndex = 24;
            this.lbltime.Visible = false;
            // 
            // btnnewpassword
            // 
            this.btnnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.btnnewpassword.Enabled = false;
            this.btnnewpassword.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnewpassword.ForeColor = System.Drawing.Color.Brown;
            this.btnnewpassword.Location = new System.Drawing.Point(55, 389);
            this.btnnewpassword.Name = "btnnewpassword";
            this.btnnewpassword.Size = new System.Drawing.Size(291, 32);
            this.btnnewpassword.TabIndex = 23;
            this.btnnewpassword.Text = "Sıfırla";
            this.btnnewpassword.UseVisualStyleBackColor = false;
            // 
            // txtresetcode
            // 
            this.txtresetcode.Enabled = false;
            this.txtresetcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresetcode.Location = new System.Drawing.Point(158, 289);
            this.txtresetcode.Name = "txtresetcode";
            this.txtresetcode.Size = new System.Drawing.Size(188, 27);
            this.txtresetcode.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kayıtlı mail adresinizi giriniz..";
            // 
            // lblwarning
            // 
            this.lblwarning.AutoSize = true;
            this.lblwarning.BackColor = System.Drawing.Color.Transparent;
            this.lblwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblwarning.Location = new System.Drawing.Point(24, 76);
            this.lblwarning.Name = "lblwarning";
            this.lblwarning.Size = new System.Drawing.Size(0, 20);
            this.lblwarning.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Geri");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnpush
            // 
            this.btnpush.BackColor = System.Drawing.Color.Transparent;
            this.btnpush.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpush.ForeColor = System.Drawing.Color.Brown;
            this.btnpush.Location = new System.Drawing.Point(55, 344);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(291, 32);
            this.btnpush.TabIndex = 16;
            this.btnpush.Text = "Kodu Gönder";
            this.btnpush.UseVisualStyleBackColor = false;
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(158, 246);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(188, 27);
            this.txtmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "E-Mail:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 542);
            this.Controls.Add(this.grpresetpassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırla";
            this.grpresetpassword.ResumeLayout(false);
            this.grpresetpassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpresetpassword;
        private System.Windows.Forms.Label lblwarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnewpassword;
        private System.Windows.Forms.TextBox txtresetcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
    }
}