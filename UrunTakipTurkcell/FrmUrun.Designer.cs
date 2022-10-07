namespace UrunTakipTurkcell
{
    partial class FrmUrun
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.cbxKategoriAdi = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txbÜrünId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblÜrünId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txbAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.txbÜrünAdi = new System.Windows.Forms.TextBox();
            this.lblÜrünAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(782, 333);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudStok);
            this.groupBox1.Controls.Add(this.cbxKategoriAdi);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txbÜrünId);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.lblÜrünId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbSatisFiyati);
            this.groupBox1.Controls.Add(this.lblSatisFiyati);
            this.groupBox1.Controls.Add(this.txbAlisFiyati);
            this.groupBox1.Controls.Add(this.lblAlisFiyati);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.txbÜrünAdi);
            this.groupBox1.Controls.Add(this.lblÜrünAdi);
            this.groupBox1.Location = new System.Drawing.Point(800, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 343);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(90, 104);
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(134, 22);
            this.nudStok.TabIndex = 16;
            this.nudStok.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudStok.ValueChanged += new System.EventHandler(this.nudStok_ValueChanged);
            // 
            // cbxKategoriAdi
            // 
            this.cbxKategoriAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategoriAdi.FormattingEnabled = true;
            this.cbxKategoriAdi.Location = new System.Drawing.Point(90, 220);
            this.cbxKategoriAdi.Name = "cbxKategoriAdi";
            this.cbxKategoriAdi.Size = new System.Drawing.Size(134, 24);
            this.cbxKategoriAdi.TabIndex = 6;
            this.cbxKategoriAdi.SelectedIndexChanged += new System.EventHandler(this.cbxKategoriAdi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(141, 304);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 29);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(37, 298);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(83, 29);
            this.btnGüncelle.TabIndex = 9;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(141, 260);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 29);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txbÜrünId
            // 
            this.txbÜrünId.Location = new System.Drawing.Point(90, 27);
            this.txbÜrünId.Name = "txbÜrünId";
            this.txbÜrünId.Size = new System.Drawing.Size(134, 22);
            this.txbÜrünId.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(37, 260);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 29);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblÜrünId
            // 
            this.lblÜrünId.AutoSize = true;
            this.lblÜrünId.Location = new System.Drawing.Point(4, 30);
            this.lblÜrünId.Name = "lblÜrünId";
            this.lblÜrünId.Size = new System.Drawing.Size(55, 16);
            this.lblÜrünId.TabIndex = 10;
            this.lblÜrünId.Text = "Ürün Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori Adı :";
            // 
            // txbSatisFiyati
            // 
            this.txbSatisFiyati.Location = new System.Drawing.Point(90, 180);
            this.txbSatisFiyati.Name = "txbSatisFiyati";
            this.txbSatisFiyati.Size = new System.Drawing.Size(134, 22);
            this.txbSatisFiyati.TabIndex = 5;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(4, 183);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(78, 16);
            this.lblSatisFiyati.TabIndex = 6;
            this.lblSatisFiyati.Text = "Satis Fiyatı :";
            // 
            // txbAlisFiyati
            // 
            this.txbAlisFiyati.Location = new System.Drawing.Point(90, 139);
            this.txbAlisFiyati.Name = "txbAlisFiyati";
            this.txbAlisFiyati.Size = new System.Drawing.Size(134, 22);
            this.txbAlisFiyati.TabIndex = 4;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Location = new System.Drawing.Point(4, 142);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(70, 16);
            this.lblAlisFiyati.TabIndex = 4;
            this.lblAlisFiyati.Text = "Alış Fiyatı :";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(4, 104);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(82, 16);
            this.lblStok.TabIndex = 2;
            this.lblStok.Text = "Stok Adedi : ";
            // 
            // txbÜrünAdi
            // 
            this.txbÜrünAdi.Location = new System.Drawing.Point(90, 62);
            this.txbÜrünAdi.Name = "txbÜrünAdi";
            this.txbÜrünAdi.Size = new System.Drawing.Size(134, 22);
            this.txbÜrünAdi.TabIndex = 2;
            // 
            // lblÜrünAdi
            // 
            this.lblÜrünAdi.AutoSize = true;
            this.lblÜrünAdi.Location = new System.Drawing.Point(4, 65);
            this.lblÜrünAdi.Name = "lblÜrünAdi";
            this.lblÜrünAdi.Size = new System.Drawing.Size(64, 16);
            this.lblÜrünAdi.TabIndex = 0;
            this.lblÜrünAdi.Text = "Ürün Adı :";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUrun";
            this.Text = "formUrun";
            this.Load += new System.EventHandler(this.formUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbÜrünAdi;
        private System.Windows.Forms.Label lblÜrünAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txbAlisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSatisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txbÜrünId;
        private System.Windows.Forms.Label lblÜrünId;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbxKategoriAdi;
        private System.Windows.Forms.NumericUpDown nudStok;
    }
}