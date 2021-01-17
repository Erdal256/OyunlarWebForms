using OyunlarWinForms._2_Business.Enums;
using OyunlarWinForms._2_Business.Models;
using OyunlarWinForms._2_Business.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace OyunlarWinForms._3_UserInterface
{
    public partial class OyunDuzenle : Form
    {
        public int Id { get; set; }

        private TurService turService = new TurService();
        private YilService yilService = new YilService();
        private OyunService oyunService = new OyunService();

        private readonly Oyunlar _oyunlarForm;

        public OyunDuzenle(Oyunlar oyunlarForm)
        {
            InitializeComponent();

            _oyunlarForm = oyunlarForm;
            this.MdiParent = oyunlarForm.MdiParent; // OyunYoneticisi
            this.WindowState = FormWindowState.Maximized;
            //this.Show(); // Id hep 0 gelir
        }

        private void OyunDuzenle_Load(object sender, EventArgs e)
        {
            FillYillar();
            FillTurler();
            FillDetay();
        }

        private void FillTurler()
        {
            lbTurleri.Items.Clear();
            var turler = turService.GetList();
            if (turler == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbTurleri.ValueMember = "Id";
            lbTurleri.DisplayMember = "Adi";
            lbTurleri.DataSource = turler;
            lbTurleri.ClearSelected();
        }

        private void FillYillar()
        {
            ddlYili.Items.Clear();
            var yillar = yilService.GetList();
            yillar.Insert(0, new YilModel()
            {
                Id = -1,
                Degeri = "-- Seçiniz --"
            });
            ddlYili.ValueMember = "Id";
            ddlYili.DisplayMember = "Degeri";
            ddlYili.DataSource = yillar;
            ddlYili.SelectedIndex = 0;
        }

        private void FillDetay()
        {
            var oyun = oyunService.GetById(Id);
            if (oyun == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbAdi.Text = oyun.Adi;
            tbKazanci.Text = "";
            if (oyun.Kazanci != null)
                tbKazanci.Text = oyun.Kazanci.Value.ToString(new CultureInfo("tr"));
            tbMaliyeti.Text = "";
            if (oyun.Maliyeti != null)
                tbMaliyeti.Text = oyun.Maliyeti.Value.ToString(new CultureInfo("tr"));
            ddlYili.SelectedValue = oyun.YilId;
            if (oyun.Turler != null && oyun.Turler.Count > 0)
            {
                for (int i = 0; i < lbTurleri.Items.Count; i++)
                {
                    var turItem = lbTurleri.Items[i] as TurModel;
                    for (int j = 0; j < oyun.Turler.Count; j++)
                    {
                        var tur = oyun.Turler[j];
                        if (turItem.Id == tur.Id)
                        {
                            lbTurleri.SetSelected(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            var model = new OyunModel();
            model.Id = Id;
            model.Adi = tbAdi.Text;
            model.Kazanci = null;
            if (!string.IsNullOrWhiteSpace(tbKazanci.Text))
                model.Kazanci = Convert.ToDouble(tbKazanci.Text.Trim(), new CultureInfo("tr"));
            model.Maliyeti = null;
            if (!string.IsNullOrWhiteSpace(tbMaliyeti.Text))
                model.Maliyeti = Convert.ToDouble(tbMaliyeti.Text.Trim(), new CultureInfo("tr"));
            model.YilId = Convert.ToInt32(ddlYili.SelectedValue);
            model.Turler = new List<TurModel>();
            foreach (var listItem in lbTurleri.SelectedItems)
            {
                var turItem = (TurModel)listItem;
                model.Turler.Add(turItem);
            }

            var islem = oyunService.Update(model);
            if (islem == Islem.Hata)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (islem == Islem.BasarisizDegerBos)
            {
                MessageBox.Show("Formdaki * ile işaretlenmiş alanlar dolu olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (islem == Islem.BasarisizKayitVar)
            {
                MessageBox.Show("Girdiğiniz ada sahip oyun kaydı bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // işlem başarılı
            {
                this.Close();
                _oyunlarForm.FillGrid();
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbAdi.Clear();
            tbMaliyeti.Text = "";
            tbKazanci.Text = "";
            ddlYili.SelectedIndex = 0;
            lbTurleri.ClearSelected();
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
