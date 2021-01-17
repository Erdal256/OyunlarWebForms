
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
            this.ddlYılı = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaliyetiBaşlangıç = new System.Windows.Forms.TextBox();
            this.tbMaliyetiBitiş = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKazancıBitiş = new System.Windows.Forms.TextBox();
            this.tbKzancıBaşlangıç = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTürleri = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlSayfa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyunlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOyunlar
            // 
            this.dgvOyunlar.AllowUserToAddRows = false;
            this.dgvOyunlar.AllowUserToDeleteRows = false;
            this.dgvOyunlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOyunlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyunlar.Location = new System.Drawing.Point(13, 191);
            this.dgvOyunlar.MultiSelect = false;
            this.dgvOyunlar.Name = "dgvOyunlar";
            this.dgvOyunlar.ReadOnly = true;
            this.dgvOyunlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyunlar.Size = new System.Drawing.Size(775, 182);
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
            this.bSorgula.Location = new System.Drawing.Point(67, 162);
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
            this.label2.Location = new System.Drawing.Point(379, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yılı";
            // 
            // ddlYılı
            // 
            this.ddlYılı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlYılı.FormattingEnabled = true;
            this.ddlYılı.Location = new System.Drawing.Point(424, 17);
            this.ddlYılı.Name = "ddlYılı";
            this.ddlYılı.Size = new System.Drawing.Size(330, 21);
            this.ddlYılı.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maliyeti";
            // 
            // tbMaliyetiBaşlangıç
            // 
            this.tbMaliyetiBaşlangıç.Location = new System.Drawing.Point(67, 54);
            this.tbMaliyetiBaşlangıç.Name = "tbMaliyetiBaşlangıç";
            this.tbMaliyetiBaşlangıç.Size = new System.Drawing.Size(135, 20);
            this.tbMaliyetiBaşlangıç.TabIndex = 7;
            // 
            // tbMaliyetiBitiş
            // 
            this.tbMaliyetiBitiş.Location = new System.Drawing.Point(224, 54);
            this.tbMaliyetiBitiş.Name = "tbMaliyetiBitiş";
            this.tbMaliyetiBitiş.Size = new System.Drawing.Size(148, 20);
            this.tbMaliyetiBitiş.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // tbKazancıBitiş
            // 
            this.tbKazancıBitiş.Location = new System.Drawing.Point(595, 57);
            this.tbKazancıBitiş.Name = "tbKazancıBitiş";
            this.tbKazancıBitiş.Size = new System.Drawing.Size(148, 20);
            this.tbKazancıBitiş.TabIndex = 12;
            // 
            // tbKzancıBaşlangıç
            // 
            this.tbKzancıBaşlangıç.Location = new System.Drawing.Point(438, 57);
            this.tbKzancıBaşlangıç.Name = "tbKzancıBaşlangıç";
            this.tbKzancıBaşlangıç.Size = new System.Drawing.Size(135, 20);
            this.tbKzancıBaşlangıç.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kazancı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Türleri";
            // 
            // lbTürleri
            // 
            this.lbTürleri.FormattingEnabled = true;
            this.lbTürleri.Location = new System.Drawing.Point(67, 80);
            this.lbTürleri.Name = "lbTürleri";
            this.lbTürleri.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTürleri.Size = new System.Drawing.Size(289, 69);
            this.lbTürleri.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sayfa";
            // 
            // ddlSayfa
            // 
            this.ddlSayfa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSayfa.FormattingEnabled = true;
            this.ddlSayfa.Location = new System.Drawing.Point(622, 397);
            this.ddlSayfa.Name = "ddlSayfa";
            this.ddlSayfa.Size = new System.Drawing.Size(121, 21);
            this.ddlSayfa.TabIndex = 17;
            this.ddlSayfa.SelectedIndexChanged += new System.EventHandler(this.ddlSayfa_SelectedIndexChanged);
            // 
            // OyunRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlSayfa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTürleri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKazancıBitiş);
            this.Controls.Add(this.tbKzancıBaşlangıç);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaliyetiBitiş);
            this.Controls.Add(this.tbMaliyetiBaşlangıç);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlYılı);
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
        private System.Windows.Forms.ComboBox ddlYılı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaliyetiBaşlangıç;
        private System.Windows.Forms.TextBox tbMaliyetiBitiş;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKazancıBitiş;
        private System.Windows.Forms.TextBox tbKzancıBaşlangıç;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbTürleri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlSayfa;
    }
}