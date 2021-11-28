
namespace dövizAlimSatim.Views.Wallet
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.grpwallet = new System.Windows.Forms.GroupBox();
            this.lblamound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbbuy = new System.Windows.Forms.TabPage();
            this.tbsell = new System.Windows.Forms.TabPage();
            this.txtpush = new System.Windows.Forms.TextBox();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnpull = new System.Windows.Forms.Button();
            this.txtpull = new System.Windows.Forms.TextBox();
            this.pctrbxunlogin = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpwallet.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbbuy.SuspendLayout();
            this.tbsell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxunlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpwallet
            // 
            this.grpwallet.BackColor = System.Drawing.Color.Transparent;
            this.grpwallet.Controls.Add(this.pctrbxunlogin);
            this.grpwallet.Controls.Add(this.tabControl1);
            this.grpwallet.Controls.Add(this.lblamound);
            this.grpwallet.Controls.Add(this.label1);
            this.grpwallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpwallet.ForeColor = System.Drawing.Color.White;
            this.grpwallet.Location = new System.Drawing.Point(12, 12);
            this.grpwallet.Name = "grpwallet";
            this.grpwallet.Size = new System.Drawing.Size(404, 456);
            this.grpwallet.TabIndex = 12;
            this.grpwallet.TabStop = false;
            this.grpwallet.Text = "Cüzdan";
            // 
            // lblamound
            // 
            this.lblamound.AutoSize = true;
            this.lblamound.BackColor = System.Drawing.Color.Transparent;
            this.lblamound.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamound.ForeColor = System.Drawing.Color.White;
            this.lblamound.Location = new System.Drawing.Point(136, 62);
            this.lblamound.Name = "lblamound";
            this.lblamound.Size = new System.Drawing.Size(42, 19);
            this.lblamound.TabIndex = 14;
            this.lblamound.Text = "0TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bakiye:";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbbuy);
            this.tabControl1.Controls.Add(this.tbsell);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 41);
            this.tabControl1.Location = new System.Drawing.Point(33, 122);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(9, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 285);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            // 
            // tbbuy
            // 
            this.tbbuy.BackColor = System.Drawing.Color.White;
            this.tbbuy.Controls.Add(this.btnpush);
            this.tbbuy.Controls.Add(this.txtpush);
            this.tbbuy.ForeColor = System.Drawing.Color.White;
            this.tbbuy.Location = new System.Drawing.Point(4, 45);
            this.tbbuy.Name = "tbbuy";
            this.tbbuy.Padding = new System.Windows.Forms.Padding(3);
            this.tbbuy.Size = new System.Drawing.Size(330, 236);
            this.tbbuy.TabIndex = 0;
            this.tbbuy.Text = "Yatır";
            // 
            // tbsell
            // 
            this.tbsell.BackColor = System.Drawing.Color.White;
            this.tbsell.Controls.Add(this.btnpull);
            this.tbsell.Controls.Add(this.txtpull);
            this.tbsell.ForeColor = System.Drawing.Color.White;
            this.tbsell.Location = new System.Drawing.Point(4, 45);
            this.tbsell.Name = "tbsell";
            this.tbsell.Padding = new System.Windows.Forms.Padding(3);
            this.tbsell.Size = new System.Drawing.Size(330, 236);
            this.tbsell.TabIndex = 1;
            this.tbsell.Text = "Çek";
            // 
            // txtpush
            // 
            this.txtpush.BackColor = System.Drawing.Color.Red;
            this.txtpush.Location = new System.Drawing.Point(48, 61);
            this.txtpush.Name = "txtpush";
            this.txtpush.Size = new System.Drawing.Size(232, 41);
            this.txtpush.TabIndex = 0;
            // 
            // btnpush
            // 
            this.btnpush.BackColor = System.Drawing.Color.Transparent;
            this.btnpush.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpush.ForeColor = System.Drawing.Color.Brown;
            this.btnpush.Location = new System.Drawing.Point(48, 146);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(232, 31);
            this.btnpush.TabIndex = 23;
            this.btnpush.Text = "Tamamla";
            this.btnpush.UseVisualStyleBackColor = false;
            // 
            // btnpull
            // 
            this.btnpull.BackColor = System.Drawing.Color.Transparent;
            this.btnpull.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpull.ForeColor = System.Drawing.Color.Brown;
            this.btnpull.Location = new System.Drawing.Point(48, 146);
            this.btnpull.Name = "btnpull";
            this.btnpull.Size = new System.Drawing.Size(232, 31);
            this.btnpull.TabIndex = 25;
            this.btnpull.Text = "Tamamla";
            this.btnpull.UseVisualStyleBackColor = false;
            // 
            // txtpull
            // 
            this.txtpull.BackColor = System.Drawing.Color.Red;
            this.txtpull.Location = new System.Drawing.Point(48, 61);
            this.txtpull.Name = "txtpull";
            this.txtpull.Size = new System.Drawing.Size(232, 41);
            this.txtpull.TabIndex = 24;
            // 
            // pctrbxunlogin
            // 
            this.pctrbxunlogin.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxunlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrbxunlogin.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxunlogin.Image")));
            this.pctrbxunlogin.Location = new System.Drawing.Point(355, 20);
            this.pctrbxunlogin.Name = "pctrbxunlogin";
            this.pctrbxunlogin.Size = new System.Drawing.Size(43, 40);
            this.pctrbxunlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxunlogin.TabIndex = 19;
            this.pctrbxunlogin.TabStop = false;
            this.toolTip1.SetToolTip(this.pctrbxunlogin, "Geri");
            this.pctrbxunlogin.Click += new System.EventHandler(this.pctrbxunlogin_Click);
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(427, 481);
            this.Controls.Add(this.grpwallet);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cüzdan";
            this.grpwallet.ResumeLayout(false);
            this.grpwallet.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbbuy.ResumeLayout(false);
            this.tbbuy.PerformLayout();
            this.tbsell.ResumeLayout(false);
            this.tbsell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxunlogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpwallet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbbuy;
        private System.Windows.Forms.TabPage tbsell;
        private System.Windows.Forms.Label lblamound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpush;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Button btnpull;
        private System.Windows.Forms.TextBox txtpull;
        private System.Windows.Forms.PictureBox pctrbxunlogin;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}