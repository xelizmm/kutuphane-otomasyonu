
namespace Kutuphane
{
    partial class Ogrenci_paneli_emanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_paneli_emanet));
            this.data_liste = new System.Windows.Forms.DataGridView();
            this.Btn_tum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ara = new System.Windows.Forms.Button();
            this.Txt_ogrno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_liste
            // 
            this.data_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_liste.Location = new System.Drawing.Point(12, 212);
            this.data_liste.Name = "data_liste";
            this.data_liste.Size = new System.Drawing.Size(630, 208);
            this.data_liste.TabIndex = 15;
            // 
            // Btn_tum
            // 
            this.Btn_tum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_tum.Location = new System.Drawing.Point(13, 138);
            this.Btn_tum.Name = "Btn_tum";
            this.Btn_tum.Size = new System.Drawing.Size(146, 33);
            this.Btn_tum.TabIndex = 14;
            this.Btn_tum.Text = "TÜM KAYITLARI GÖSTER";
            this.Btn_tum.UseVisualStyleBackColor = false;
            this.Btn_tum.Click += new System.EventHandler(this.Btn_tum_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Btn_ara);
            this.groupBox1.Controls.Add(this.Txt_ogrno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(185, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade Edilen Kitap";
            // 
            // Btn_ara
            // 
            this.Btn_ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_ara.Location = new System.Drawing.Point(330, 25);
            this.Btn_ara.Name = "Btn_ara";
            this.Btn_ara.Size = new System.Drawing.Size(111, 28);
            this.Btn_ara.TabIndex = 2;
            this.Btn_ara.Text = "ARA";
            this.Btn_ara.UseVisualStyleBackColor = false;
            this.Btn_ara.Click += new System.EventHandler(this.Btn_ara_Click_1);
            // 
            // Txt_ogrno
            // 
            this.Txt_ogrno.Location = new System.Drawing.Point(86, 30);
            this.Txt_ogrno.Name = "Txt_ogrno";
            this.Txt_ogrno.Size = new System.Drawing.Size(228, 20);
            this.Txt_ogrno.TabIndex = 1;
            this.Txt_ogrno.Click += new System.EventHandler(this.Txt_ogrno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // Btn_anasayfa
            // 
            this.Btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_anasayfa.Location = new System.Drawing.Point(12, 70);
            this.Btn_anasayfa.Name = "Btn_anasayfa";
            this.Btn_anasayfa.Size = new System.Drawing.Size(147, 36);
            this.Btn_anasayfa.TabIndex = 12;
            this.Btn_anasayfa.Text = "ANASAYFA";
            this.Btn_anasayfa.UseVisualStyleBackColor = false;
            this.Btn_anasayfa.Click += new System.EventHandler(this.Btn_anasayfa_Click_1);
            // 
            // Ogrenci_paneli_emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 493);
            this.Controls.Add(this.data_liste);
            this.Controls.Add(this.Btn_tum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_anasayfa);
            this.Name = "Ogrenci_paneli_emanet";
            this.Text = "Ogrenci_paneli_emanet";
            ((System.ComponentModel.ISupportInitialize)(this.data_liste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_liste;
        private System.Windows.Forms.Button Btn_tum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_ara;
        private System.Windows.Forms.TextBox Txt_ogrno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_anasayfa;
    }
}