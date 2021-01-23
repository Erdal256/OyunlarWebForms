using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OyunlarWinForms._2_Business.Models;
using OyunlarWinForms._2_Business.Services;

namespace OyunlarWinForms._3_UserInterface
{
    public partial class OyunRaporu : Form
    {
        private readonly OyunYoneticisi _oyunYoneticisiForm;

        private OyunService oyunService = new OyunService();
        private TurService turService = new TurService();
        private YilService yilService = new YilService();

        private bool formIlkYuklemeVeyaSorgula = true;

        public OyunRaporu(OyunYoneticisi oyunYoneticisiForm)
        {
            InitializeComponent();

            _oyunYoneticisiForm = oyunYoneticisiForm;
            this.MdiParent = _oyunYoneticisiForm;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void OyunRaporu_Load(object sender, EventArgs e)
        {
            FillSiralama();
            FillYillar();
            FillTurler();
            FillGrid();
            SetColumnVisibilities();
            formIlkYuklemeVeyaSorgula = false;
        }

        private void FillSiralama()
        {
            ddlSiralamaSutun.Items.Clear();
            ddlSiralamaSutun.Items.Add("Oyun Adı");
            ddlSiralamaSutun.Items.Add("Oyun Maliyeti");
            ddlSiralamaSutun.Items.Add("Oyun Kazancı");
            ddlSiralamaSutun.Items.Add("Oyun Türü");
            ddlSiralamaSutun.Items.Add("Oyun Yılı");
            //ddlSiralamaSutun.SelectedIndex = 0; // oyun adı
            ddlSiralamaSutun.Text = "Oyun Adı";
            //MessageBox.Show(ddlSiralamaSutun.Text);
            ddlSiralamaDeger.Items.Clear();
            ddlSiralamaDeger.Items.Add("Artan");
            ddlSiralamaDeger.Items.Add("Azalan");
            ddlSiralamaDeger.Text = "Artan";
        }

        private void FillTurler()
        {
            var turler = turService.GetList();
            if (turler == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!");
                return;
            }
            lbTurleri.ValueMember = "Id";
            lbTurleri.DisplayMember = "Adi";
            lbTurleri.DataSource = turler;
            lbTurleri.ClearSelected();
        }

        private void FillYillar()
        {
            var yillar = yilService.GetList();
            if (yillar == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!");
                return;
            }
            yillar.Insert(0, new YilModel()
            {
                Id = -1,
                Degeri = "-- Tümü --"
            });
            ddlYili.ValueMember = "Id";
            ddlYili.DisplayMember = "Degeri";
            ddlYili.DataSource = yillar;
            ddlYili.SelectedIndex = 0;
            //MessageBox.Show(ddlYili.SelectedValue + " " + ddlYili.Text);
        }

        private void SetColumnVisibilities()
        {
            dgvOyunlar.Columns["Id"].Visible = false;
            dgvOyunlar.Columns["TurId"].Visible = false;
        }

        private void FillGrid(bool sayfalariDoldur = true)
        {
            // dynamic linq

            var query = oyunService.GetQuery();

            #region Sıralama
            //query = query.OrderBy(o => o.Adi).ThenBy(o => o.Kazanci).ThenByDescending(o => o.TurAdi);
            if (ddlSiralamaSutun.Text == "Oyun Adı")
            {
                if (ddlSiralamaDeger.Text == "Artan")
                {
                    query = query.OrderBy(o => o.Adi);
                }
                else
                {
                    query = query.OrderByDescending(o => o.Adi);
                }
            }
            else if (ddlSiralamaSutun.Text == "Oyun Maliyeti")
            {
                if (ddlSiralamaDeger.Text == "Artan")
                {
                    query = query.OrderBy(o => o.Maliyeti);
                }
                else
                {
                    query = query.OrderByDescending(o => o.Maliyeti);
                }
            }
            else if (ddlSiralamaSutun.Text == "Oyun Kazancı")
            {
                if (ddlSiralamaDeger.Text == "Artan")
                {
                    query = query.OrderBy(o => o.Kazanci);
                }
                else
                {
                    query = query.OrderByDescending(o => o.Kazanci);
                }
            }
            else if (ddlSiralamaSutun.Text == "Oyun Yılı")
            {
                if (ddlSiralamaDeger.Text == "Artan")
                {
                    query = query.OrderBy(o => o.YilId);
                }
                else
                {
                    query = query.OrderByDescending(o => o.YilId);
                }
            }
            else if (ddlSiralamaSutun.Text == "Oyun Türü")
            {
                if (ddlSiralamaDeger.Text == "Artan")
                {
                    query = query.OrderBy(o => o.TurAdi);
                }
                else
                {
                    query = query.OrderByDescending(o => o.TurAdi);
                }
            }
            #endregion

            #region Filtreleme
            // doğru yöntem:
            if (!string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                //query = query.Where(o => o.Adi.ToUpper() == tbAdi.Text.ToUpper().Trim()); // adi = 'gta5'
                //query = query.Where(o => o.Adi.ToUpper().StartsWith(tbAdi.Text.ToUpper().Trim())); // adi like 'gta%'
                //query = query.Where(o => o.Adi.ToUpper().EndsWith(tbAdi.Text.ToUpper().Trim())); // adi like '%gta'
                query = query.Where(o => o.Adi.ToUpper().Contains(tbAdi.Text.ToUpper().Trim())); // adi like '%gta%'
            }

            if (ddlYili.SelectedIndex > 0) // 0: Tümü
            {
                int yilId = Convert.ToInt32(ddlYili.SelectedValue);
                query = query.Where(o => o.YilId == yilId);
            }

            // aralık (range) filtreleme
            if (!string.IsNullOrWhiteSpace(tbMaliyetiBaslangic.Text))
            {
                double maliyetiBaslangic = Convert.ToDouble(tbMaliyetiBaslangic.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Maliyeti >= maliyetiBaslangic);
            }
            if (!string.IsNullOrWhiteSpace(tbMaliyetiBitis.Text))
            {
                double maliyetiBitis = Convert.ToDouble(tbMaliyetiBitis.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Maliyeti <= maliyetiBitis);
            }
            if (!string.IsNullOrWhiteSpace(tbKazanciBaslangic.Text))
            {
                double kazanciBaslangic = Convert.ToDouble(tbKazanciBaslangic.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Kazanci >= kazanciBaslangic);
            }
            if (!string.IsNullOrWhiteSpace(tbKazanciBitis.Text))
            {
                double kazanciBitis = Convert.ToDouble(tbKazanciBitis.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Kazanci <= kazanciBitis);
            }

            if (lbTurleri.SelectedItems.Count > 0)
            {
                List<int> turIdleri = new List<int>();
                foreach (var selectedItem in lbTurleri.SelectedItems)
                {
                    var turItem = selectedItem as TurModel;
                    turIdleri.Add(turItem.Id);
                }
                query = query.Where(o => turIdleri.Contains(o.TurId ?? 0));
            }
            #endregion

            #region Sayfalama
            int toplamKayitSayisi = query.Count();
            int herBirSayfadakiKayitSayisi = Convert.ToInt32(ConfigurationManager.AppSettings["HerBirSayfadakiKayitSayisi"]);

            int sayfaSayisi = Convert.ToInt32(Math.Ceiling((decimal)toplamKayitSayisi / (decimal)herBirSayfadakiKayitSayisi));
            int sayfaNo = 1;
            if (ddlSayfa.Text != "")
                sayfaNo = Convert.ToInt32(ddlSayfa.Text);
            if (sayfalariDoldur)
            {
                ddlSayfa.Items.Clear();
                for (int i = 1; i <= sayfaSayisi; i++)
                {
                    ddlSayfa.Items.Add(i);
                }
                sayfaNo = 1;
                ddlSayfa.Text = sayfaNo.ToString();
            }

            query = query.Skip((sayfaNo - 1) * herBirSayfadakiKayitSayisi).Take(herBirSayfadakiKayitSayisi);
            #endregion

            var oyunlar = query.ToList(); // en son query üzerinden list'e dönüştürülür

            // yanlış yöntem:
            //if (!string.IsNullOrWhiteSpace(tbAdi.Text))
            //    oyunlar = oyunlar.Where(o => o.Adi.ToUpper() == tbAdi.Text.ToUpper().Trim()).ToList();

            dgvOyunlar.DataSource = oyunlar;
            dgvOyunlar.ClearSelection();
        }

        private void bSorgula_Click(object sender, EventArgs e)
        {
            formIlkYuklemeVeyaSorgula = true;
            FillGrid();
            formIlkYuklemeVeyaSorgula = false;
        }

        private void OyunRaporu_Shown(object sender, EventArgs e)
        {
            dgvOyunlar.ClearSelection();
        }

        private void ddlSayfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formIlkYuklemeVeyaSorgula)
                FillGrid(false);
        }

        private void ddlSiralamaSutun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formIlkYuklemeVeyaSorgula)
                FillGrid(false);
        }

        private void ddlSiralamaDeger_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formIlkYuklemeVeyaSorgula)
                FillGrid(false);
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAdi.Clear();
            ddlSayfa.SelectedIndex = 0;
            tbMaliyetiBaslangic.Text = "";
            tbMaliyetiBitis.Text = "";
            tbKazanciBaslangic.Text = "";
            tbKazanciBitis.Text = "";
            lbTurleri.ClearSelected();
            ddlSiralamaSutun.Text = "Oyun Adı";
            ddlSiralamaDeger.Text = "Artan";
            formIlkYuklemeVeyaSorgula = true;
            FiilGrid();
            formIlkYuklemeVeyaSorgula = false;

        }

        private void FiilGrid()
        {
            throw new NotImplementedException();
        }
    }
}
