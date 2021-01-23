
namespace OyunlarWinForms._3_UserInterface
{
    partial class OyunRaporu
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
            this.dgvOyunlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.bSorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlYili = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaliyetiBaslangic = new System.Windows.Forms.TextBox();
            this.tbMaliyetiBitis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKazanciBitis = new System.Windows.Forms.TextBox();
            this.tbKazanciBaslangic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTurleri = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlSayfa = new System.Windows.Forms.ComboBox();
            this.ddlSiralamaDeger = new System.Windows.Forms.ComboBox();
            this.ddlSiralamaSutun = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyunlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOyunlar
            // 
            this.dgvOyunlar.AllowUserToAddRows = false;
            this.dgvOyunlar.AllowUserToDeleteRows = false;
            this.dgvOyunlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOyunlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyunlar.Location = new System.Drawing.Point(13, 197);
            this.dgvOyunlar.MultiSelect = false;
            this.dgvOyunlar.Name = "dgvOyunlar";
            this.dgvOyunlar.ReadOnly = true;
            this.dgvOyunlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyunlar.Size = new System.Drawing.Size(775, 176);
            this.dgvOyunlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(67, 10);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(289, 20);
            this.tbAdi.TabIndex = 2;
            // 
            // bSorgula
            // 
            this.bSorgula.Location = new System.Drawing.Point(67, 168);
            this.bSorgula.Name = "bSorgula";
            this.bSorgula.Size = new System.Drawing.Size(75, 23);
            this.bSorgula.TabIndex = 3;
            this.bSorgula.Text = "Sorgula";
            this.bSorgula.UseVisualStyleBackColor = true;
            this.bSorgula.Click += new System.EventHandler(this.bSorgula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yılı";
            // 
            // ddlYili
            // 
            this.ddlYili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlYili.FormattingEnabled = true;
            this.ddlYili.Location = new System.Drawing.Point(426, 10);
            this.ddlYili.Name = "ddlYili";
            this.ddlYili.Size = new System.Drawing.Size(362, 21);
            this.ddlYili.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maliyeti";
            // 
            // tbMaliyetiBaslangic
            // 
            this.tbMaliyetiBaslangic.Location = new System.Drawing.Point(67, 41);
            this.tbMaliyetiBaslangic.Name = "tbMaliyetiBaslangic";
            this.tbMaliyetiBaslangic.Size = new System.Drawing.Size(130, 20);
            this.tbMaliyetiBaslangic.TabIndex = 7;
            // 
            // tbMaliyetiBitis
            // 
            this.tbMaliyetiBitis.Location = new System.Drawing.Point(226, 41);
            this.tbMaliyetiBitis.Name = "tbMaliyetiBitis";
            this.tbMaliyetiBitis.Size = new System.Drawing.Size(130, 20);
            this.tbMaliyetiBitis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // tbKazanciBitis
            // 
            this.tbKazanciBitis.Location = new System.Drawing.Point(585, 41);
            this.tbKazanciBitis.Name = "tbKazanciBitis";
            this.tbKazanciBitis.Size = new System.Drawing.Size(130, 20);
            this.tbKazanciBitis.TabIndex = 12;
            // 
            // tbKazanciBaslangic
            // 
            this.tbKazanciBaslangic.Location = new System.Drawing.Point(426, 41);
            this.tbKazanciBaslangic.Name = "tbKazanciBaslangic";
            this.tbKazanciBaslangic.Size = new System.Drawing.Size(130, 20);
            this.tbKazanciBaslangic.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kazancı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Türleri";
            // 
            // lbTurleri
            // 
            this.lbTurleri.FormattingEnabled = true;
            this.lbTurleri.Location = new System.Drawing.Point(67, 67);
            this.lbTurleri.Name = "lbTurleri";
            this.lbTurleri.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTurleri.Size = new System.Drawing.Size(289, 95);
            this.lbTurleri.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sayfa";
            // 
            // ddlSayfa
            // 
            this.ddlSayfa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSayfa.FormattingEnabled = true;
            this.ddlSayfa.Location = new System.Drawing.Point(667, 379);
            this.ddlSayfa.Name = "ddlSayfa";
            this.ddlSayfa.Size = new System.Drawing.Size(121, 21);
            this.ddlSayfa.TabIndex = 17;
            this.ddlSayfa.SelectedIndexChanged += new System.EventHandler(this.ddlSayfa_SelectedIndexChanged);
            // 
            // ddlSiralamaDeger
            // 
            this.ddlSiralamaDeger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSiralamaDeger.FormattingEnabled = true;
            this.ddlSiralamaDeger.Location = new System.Drawing.Point(491, 379);
            this.ddlSiralamaDeger.Name = "ddlSiralamaDeger";
            this.ddlSiralamaDeger.Size = new System.Drawing.Size(121, 21);
            this.ddlSiralamaDeger.TabIndex = 18;
            this.ddlSiralamaDeger.SelectedIndexChanged += new System.EventHandler(this.ddlSiralamaDeger_SelectedIndexChanged);
            // 
            // ddlSiralamaSutun
            // 
            this.ddlSiralamaSutun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSiralamaSutun.FormattingEnabled = true;
            this.ddlSiralamaSutun.Location = new System.Drawing.Point(364, 379);
            this.ddlSiralamaSutun.Name = "ddlSiralamaSutun";
            this.ddlSiralamaSutun.Size = new System.Drawing.Size(121, 21);
            this.ddlSiralamaSutun.TabIndex = 19;
            this.ddlSiralamaSutun.SelectedIndexChanged += new System.EventHandler(this.ddlSiralamaSutun_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sıralama";
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(148, 168);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 21;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // OyunRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ddlSiralamaSutun);
            this.Controls.Add(this.ddlSiralamaDeger);
            this.Controls.Add(this.ddlSayfa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTurleri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKazanciBitis);
            this.Controls.Add(this.tbKazanciBaslangic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaliyetiBitis);
            this.Controls.Add(this.tbMaliyetiBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlYili);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSorgula);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOyunlar);
            this.Name = "OyunRaporu";
            this.Text = "Oyun Raporu";
            this.Load += new System.EventHandler(this.OyunRaporu_Load);
            this.Shown += new System.EventHandler(this.OyunRaporu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyunlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOyunlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Button bSorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlYili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaliyetiBaslangic;
        private System.Windows.Forms.TextBox tbMaliyetiBitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKazanciBitis;
        private System.Windows.Forms.TextBox tbKazanciBaslangic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbTurleri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlSayfa;
        private System.Windows.Forms.ComboBox ddlSiralamaDeger;
        private System.Windows.Forms.ComboBox ddlSiralamaSutun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bTemizle;
    }
}