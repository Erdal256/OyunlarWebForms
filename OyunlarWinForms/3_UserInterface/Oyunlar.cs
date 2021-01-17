using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OyunlarWinForms._2_Business.Enums;
using OyunlarWinForms._2_Business.Services;

namespace OyunlarWinForms._3_UserInterface
{
    public partial class Oyunlar : Form
    {
        private OyunService oyunService = new OyunService();

        //public Oyunlar()
        //{
        //    InitializeComponent();
        //}

        private readonly OyunYoneticisi _oyunYoneticisiForm;

        public Oyunlar(OyunYoneticisi oyunYoneticisiForm)
        {
            InitializeComponent();
            _oyunYoneticisiForm = oyunYoneticisiForm;
            this.MdiParent = _oyunYoneticisiForm;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void Oyunlar_Load(object sender, EventArgs e)
        {
            //FillGrid();
        }

        private void Oyunlar_Shown(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            var oyunlar = oyunService.GetList();
            dgvOyunlar.DataSource = oyunlar;
            dgvOyunlar.ClearSelection();
            SetColumnVisibilities();
            //SetColumnNames();
            SetColumnWidths();
        }

        private void SetColumnWidths()
        {
            //dgvOyunlar.Columns["KarZarar"].Width = 150;
            foreach (DataGridViewColumn column in dgvOyunlar.Columns)
            {
                column.Width = 150;
            }
        }

        private void SetColumnNames()
        {
            dgvOyunlar.Columns["Adi"].HeaderText = "Oyun Adı";
            dgvOyunlar.Columns["Kazanci"].HeaderText = "Oyun Kazancı";
            dgvOyunlar.Columns["Maliyeti"].HeaderText = "Oyun Maliyeti";
            dgvOyunlar.Columns["YilId"].HeaderText = "Oyun Yılı";
            dgvOyunlar.Columns["KarZarar"].HeaderText = "Oyun Karı / Zararı";
        }

        private void SetColumnVisibilities()
        {
            dgvOyunlar.Columns["Id"].Visible = false;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OyunEkle form = new OyunEkle();
            //form.Show();

            OyunEkle form = new OyunEkle(this);
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOyunlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden oyun seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvOyunlar.SelectedRows[0].Cells[0].Value); // selected id
            
            OyunDetayi form = new OyunDetayi(this, id);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOyunlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden oyun seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvOyunlar.SelectedRows[0].Cells[0].Value); // selected id

            OyunDuzenle form = new OyunDuzenle(this);
            form.Id = id;
            form.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOyunlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden oyun seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvOyunlar.SelectedRows[0].Cells[0].Value); // selected id

            var dialogResult = MessageBox.Show("Seçtiğiniz oyun kaydını silmek istiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var islem = oyunService.Delete(id);
                if (islem == Islem.Hata)
                {
                    MessageBox.Show("İşlem sırasında hata meydana geldi!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    FillGrid();
                }
            }
        }
    }
}
