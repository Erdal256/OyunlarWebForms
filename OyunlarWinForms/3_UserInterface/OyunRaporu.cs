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
        
        private int sayac = 0;

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
            FillYilar();
            FillTurler();
            FillGrid();
            SetColumnVisibilities();
        }

        private void FillTurler()
        {
            var turler = turService.GetList();
            if(turler == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!");
                return;
            }
                

            lbTürleri.ValueMember = "Id";
            lbTürleri.DisplayMember = "Adı";
            lbTürleri.DataSource = turler;
            lbTürleri.ClearSelected();
        }

        private void FillYilar()
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
                Degeri = "--Tümü--"
            });
            ddlYılı.ValueMember = "Id";
            ddlYılı.DisplayMember = "Degeri";
            ddlYılı.DataSource = yillar;
            ddlYılı.SelectedIndex = 0;

        }

        private void SetColumnVisibilities()
        {
            dgvOyunlar.Columns["Id"].Visible = false;
            dgvOyunlar.Columns["TurId"].Visible = false;
        }

        private void FillGrid(bool sayfalariDoldur = true)
        {
            var query = oyunService.GetQuery();

            // doğru yöntem:
            if (!string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                //query = query.Where(o => o.Adi.ToUpper() == tbAdi.Text.ToUpper().Trim()); // adi = "gta52
                //query = query.Where(o => o.Adi.ToUpper().StartsWith(tbAdi.Text.ToUpper().Trim())); // adi like "gta%"
                //query = query.Where(o => o.Adi.ToUpper().EndsWith(tbAdi.Text.ToUpper().Trim())); // adi like "gta"
                query = query.Where(o => o.Adi.ToUpper().Contains(tbAdi.Text.ToUpper().Trim())); // adi like "%gta%"
            }
            if(ddlYılı.SelectedIndex > 0) // 0:Tümü
            {
                int yilId = Convert.ToInt32(ddlYılı.SelectedValue);
                query = query.Where(o => o.YilId == yilId);
            }
            if(!string.IsNullOrEmpty(tbMaliyetiBaşlangıç.Text))
            {
                double maliyetiBaşlangıç = Convert.ToDouble(tbMaliyetiBaşlangıç.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Maliyeti >= maliyetiBaşlangıç);
            }
            if (!string.IsNullOrEmpty(tbMaliyetiBaşlangıç.Text))
            {
                double maliyetiBitiş = Convert.ToDouble(tbMaliyetiBitiş.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Maliyeti <= maliyetiBitiş);
            }
            if (!string.IsNullOrEmpty(tbKzancıBaşlangıç.Text))
            {
                double KazancıliyetiBaşlangıç = Convert.ToDouble(tbKzancıBaşlangıç.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Kazanci >= KazancıliyetiBaşlangıç);
            }
            if (!string.IsNullOrEmpty(tbKazancıBitiş.Text))
            {
                double kazancıBitiş = Convert.ToDouble(tbKazancıBitiş.Text.Trim(), new CultureInfo("tr"));
                query = query.Where(o => o.Kazanci <= kazancıBitiş);
            }

      
            if (lbTürleri.SelectedItems.Count > 0)
            {
                List<int> turIdleri = new List<int>();
                foreach (var selectedItem in lbTürleri.SelectedItems)
                {
                    var turItem = selectedItem as TurModel;
                    turIdleri.Add(turItem.Id);
                }
                query = query.Where(o => turIdleri.Contains(o.TurId));
            }


            #region Sayfa
            int toplamKayitSayisi = query.Count();
            int herBirSayfadakiKayitSayisi = Convert.ToInt32(ConfigurationManager.AppSettings["HerBirSayfadakiKayıtSayisi"]);

            int sayfaSayisi = Convert.ToInt32(Math.Ceiling((decimal)toplamKayitSayisi / (decimal)herBirSayfadakiKayitSayisi));
           int sayfaNo = 1;
            if(ddlSayfa.Text != "")
               sayfaNo = Convert.ToInt32(ddlSayfa.Text);
            if (sayfalariDoldur)
            {
                ddlSayfa.Items.Clear();
                for (int i = 1; i <= sayfaSayisi; i++)
                {
                    ddlSayfa.Items.Add(i);
                }

                ddlSayfa.Text = sayfaNo.ToString();
            }
            
            query = query.OrderBy(o => o.Id);
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
            FillGrid();
        }

        private void OyunRaporu_Shown(object sender, EventArgs e)
        {
            dgvOyunlar.ClearSelection();
        }

        private void ddlSayfa_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilGrid(false);
        }

        private void FiilGrid(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
