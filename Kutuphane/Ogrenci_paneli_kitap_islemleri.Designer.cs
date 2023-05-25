
namespace Kutuphane
{
    partial class Ogrenci_paneli_kitap_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_paneli_kitap_islemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_kitap_ara = new System.Windows.Forms.Button();
            this.Txt_kitap_ara = new System.Windows.Forms.TextBox();
            this.Cmb_kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_listele = new System.Windows.Forms.Button();
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            this.KitapListele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Btn_kitap_ara);
            this.groupBox1.Controls.Add(this.Txt_kitap_ara);
            this.groupBox1.Controls.Add(this.Cmb_kategori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(40, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // Btn_kitap_ara
            // 
            this.Btn_kitap_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_kitap_ara.Location = new System.Drawing.Point(155, 210);
            this.Btn_kitap_ara.Name = "Btn_kitap_ara";
            this.Btn_kitap_ara.Size = new System.Drawing.Size(155, 33);
            this.Btn_kitap_ara.TabIndex = 3;
            this.Btn_kitap_ara.Text = "Ara";
            this.Btn_kitap_ara.UseVisualStyleBackColor = false;
            this.Btn_kitap_ara.Click += new System.EventHandler(this.Btn_kitap_ara_Click);
            // 
            // Txt_kitap_ara
            // 
            this.Txt_kitap_ara.Location = new System.Drawing.Point(95, 163);
            this.Txt_kitap_ara.Name = "Txt_kitap_ara";
            this.Txt_kitap_ara.Size = new System.Drawing.Size(281, 22);
            this.Txt_kitap_ara.TabIndex = 2;
            this.Txt_kitap_ara.Text = "Kitap bilgisi girin";
            this.Txt_kitap_ara.Click += new System.EventHandler(this.Txt_kitap_ara_Click);
            // 
            // Cmb_kategori
            // 
            this.Cmb_kategori.FormattingEnabled = true;
            this.Cmb_kategori.Items.AddRange(new object[] {
            "KitapAdi",
            "BarkodNo",
            "YazarAdi",
            "YayinEvi",
            "KitapTuru",
            "StokSayisi",
            "SayfaSayisi",
            "BasimYili"});
            this.Cmb_kategori.Location = new System.Drawing.Point(95, 107);
            this.Cmb_kategori.Name = "Cmb_kategori";
            this.Cmb_kategori.Size = new System.Drawing.Size(281, 23);
            this.Cmb_kategori.TabIndex = 1;
            this.Cmb_kategori.SelectedIndexChanged += new System.EventHandler(this.Cmb_kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama kriterini seçiniz";
            // 
            // Btn_listele
            // 
            this.Btn_listele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_listele.Location = new System.Drawing.Point(527, 187);
            this.Btn_listele.Name = "Btn_listele";
            this.Btn_listele.Size = new System.Drawing.Size(188, 40);
            this.Btn_listele.TabIndex = 7;
            this.Btn_listele.Text = "TÜM KAYITLARI GÖSTER";
            this.Btn_listele.UseVisualStyleBackColor = false;
            this.Btn_listele.Click += new System.EventHandler(this.Btn_listele_Click);
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_anasayfa.Location = new System.Drawing.Point(527, 132);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(188, 40);
            this.Btn_anasayfa.TabIndex = 8;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click);
            // 
            // KitapListele
            // 
            this.KitapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapListele.Location = new System.Drawing.Point(40, 371);
            this.KitapListele.Name = "KitapListele";
            this.KitapListele.Size = new System.Drawing.Size(675, 158);
            this.KitapListele.TabIndex = 9;
            // 
            // Ogrenci_paneli_kitap_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 567);
            this.Controls.Add(this.KitapListele);
            this.Controls.Add(this.Btn_anasayfa);
            this.Controls.Add(this.Btn_listele);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ogrenci_paneli_kitap_islemleri";
            this.Text = "Ogrenci_paneli_kitap_islemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_kitap_ara;
        private System.Windows.Forms.TextBox Txt_kitap_ara;
        private System.Windows.Forms.ComboBox Cmb_kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_listele;
        private System.Windows.Forms.Button Btn_anasayfa;
        private System.Windows.Forms.DataGridView KitapListele;
    }
}