
namespace CurrencyTransactions
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpkur = new System.Windows.Forms.GroupBox();
            this.lblsterlin = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.grpkur.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpkur
            // 
            this.grpkur.BackColor = System.Drawing.Color.Transparent;
            this.grpkur.Controls.Add(this.lblsterlin);
            this.grpkur.Controls.Add(this.lbleuro);
            this.grpkur.Controls.Add(this.lbldolar);
            this.grpkur.Controls.Add(this.label5);
            this.grpkur.Controls.Add(this.label4);
            this.grpkur.Controls.Add(this.label1);
            this.grpkur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpkur.ForeColor = System.Drawing.Color.White;
            this.grpkur.Location = new System.Drawing.Point(12, 38);
            this.grpkur.Name = "grpkur";
            this.grpkur.Size = new System.Drawing.Size(327, 210);
            this.grpkur.TabIndex = 11;
            this.grpkur.TabStop = false;
            this.grpkur.Text = "Kurlar";
            // 
            // lblsterlin
            // 
            this.lblsterlin.AutoSize = true;
            this.lblsterlin.BackColor = System.Drawing.Color.Transparent;
            this.lblsterlin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsterlin.ForeColor = System.Drawing.Color.White;
            this.lblsterlin.Location = new System.Drawing.Point(152, 154);
            this.lblsterlin.Name = "lblsterlin";
            this.lblsterlin.Size = new System.Drawing.Size(141, 19);
            this.lblsterlin.TabIndex = 16;
            this.lblsterlin.Text = "Yükleniyor..";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.BackColor = System.Drawing.Color.Transparent;
            this.lbleuro.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleuro.ForeColor = System.Drawing.Color.White;
            this.lbleuro.Location = new System.Drawing.Point(152, 106);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(141, 19);
            this.lbleuro.TabIndex = 15;
            this.lbleuro.Text = "Yükleniyor..";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.BackColor = System.Drawing.Color.Transparent;
            this.lbldolar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.ForeColor = System.Drawing.Color.White;
            this.lbldolar.Location = new System.Drawing.Point(152, 62);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(141, 19);
            this.lbldolar.TabIndex = 14;
            this.lbldolar.Text = "Yükleniyor..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pound:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Euro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dolar:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(148, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kaydol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(154, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "veya";
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Transparent;
            this.btngiris.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.Brown;
            this.btngiris.Location = new System.Drawing.Point(136, 312);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 32);
            this.btngiris.TabIndex = 14;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.grpkur);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Transactions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpkur.ResumeLayout(false);
            this.grpkur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsterlin;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpkur;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
    }
}

