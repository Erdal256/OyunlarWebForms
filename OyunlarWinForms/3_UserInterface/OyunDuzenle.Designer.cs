
namespace OyunlarWinForms._3_UserInterface
{
    partial class OyunDuzenle
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
            this.bKapat = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bKaydet = new System.Windows.Forms.Button();
            this.lbTurleri = new System.Windows.Forms.ListBox();
            this.ddlYili = new System.Windows.Forms.ComboBox();
            this.tbMaliyeti = new System.Windows.Forms.TextBox();
            this.tbKazanci = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bKapat
            // 
            this.bKapat.Location = new System.Drawing.Point(228, 223);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(75, 23);
            this.bKapat.TabIndex = 25;
            this.bKapat.Text = "Kapat";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(147, 223);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 24;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(66, 223);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 23;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // lbTurleri
            // 
            this.lbTurleri.FormattingEnabled = true;
            this.lbTurleri.Location = new System.Drawing.Point(66, 121);
            this.lbTurleri.Name = "lbTurleri";
            this.lbTurleri.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTurleri.Size = new System.Drawing.Size(237, 95);
            this.lbTurleri.TabIndex = 22;
            // 
            // ddlYili
            // 
            this.ddlYili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlYili.FormattingEnabled = true;
            this.ddlYili.Location = new System.Drawing.Point(66, 94);
            this.ddlYili.Name = "ddlYili";
            this.ddlYili.Size = new System.Drawing.Size(145, 21);
            this.ddlYili.TabIndex = 21;
            // 
            // tbMaliyeti
            // 
            this.tbMaliyeti.Location = new System.Drawing.Point(66, 67);
            this.tbMaliyeti.Name = "tbMaliyeti";
            this.tbMaliyeti.Size = new System.Drawing.Size(275, 20);
            this.tbMaliyeti.TabIndex = 20;
            // 
            // tbKazanci
            // 
            this.tbKazanci.Location = new System.Drawing.Point(66, 41);
            this.tbKazanci.Name = "tbKazanci";
            this.tbKazanci.Size = new System.Drawing.Size(275, 20);
            this.tbKazanci.TabIndex = 19;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(66, 15);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(275, 20);
            this.tbAdi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Türleri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yılı*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Maliyeti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kazancı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adı*:";
            // 
            // OyunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.lbTurleri);
            this.Controls.Add(this.ddlYili);
            this.Controls.Add(this.tbMaliyeti);
            this.Controls.Add(this.tbKazanci);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OyunDuzenle";
            this.Text = "Oyun Düzenle";
            this.Load += new System.EventHandler(this.OyunDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bKapat;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.ListBox lbTurleri;
        private System.Windows.Forms.ComboBox ddlYili;
        private System.Windows.Forms.TextBox tbMaliyeti;
        private System.Windows.Forms.TextBox tbKazanci;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}