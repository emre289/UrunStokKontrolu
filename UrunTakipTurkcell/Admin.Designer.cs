namespace UrunTakipTurkcell
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.bntGirisYap = new System.Windows.Forms.Button();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txbKullaniciAdi
            // 
            this.txbKullaniciAdi.Location = new System.Drawing.Point(135, 99);
            this.txbKullaniciAdi.Name = "txbKullaniciAdi";
            this.txbKullaniciAdi.Size = new System.Drawing.Size(165, 21);
            this.txbKullaniciAdi.TabIndex = 1;
            this.txbKullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bntGirisYap
            // 
            this.bntGirisYap.Location = new System.Drawing.Point(161, 189);
            this.bntGirisYap.Name = "bntGirisYap";
            this.bntGirisYap.Size = new System.Drawing.Size(97, 39);
            this.bntGirisYap.TabIndex = 3;
            this.bntGirisYap.Text = "Giriş Yap";
            this.bntGirisYap.UseVisualStyleBackColor = true;
            this.bntGirisYap.Click += new System.EventHandler(this.bntGirisYap_Click);
            // 
            // txbSifre
            // 
            this.txbSifre.Location = new System.Drawing.Point(135, 148);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(165, 21);
            this.txbSifre.TabIndex = 2;
            this.txbSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Takip Admin Giriş Paneline Hoş Geldiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Admin
            // 
            this.AcceptButton = this.bntGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntGirisYap);
            this.Controls.Add(this.txbKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbKullaniciAdi;
        private System.Windows.Forms.Button bntGirisYap;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}