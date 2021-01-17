using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class OyunDetayi : Form
    {
        private readonly Oyunlar _oyunlarForm;
        private readonly int _id;

        private OyunService oyunService = new OyunService();
        private YilService yilService = new YilService();
        private TurService turService = new TurService();

        public OyunDetayi(Oyunlar oyunlarForm, int id)
        {
            InitializeComponent();

            _id = id;

            _oyunlarForm = oyunlarForm;
            this.MdiParent = oyunlarForm.MdiParent; // OyunYoneticisi
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OyunDetayi_Load(object sender, EventArgs e)
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
            var oyun = oyunService.GetById(_id);
            if (oyun == null)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbAdi.Text = oyun.Adi;
            tbKazanci.Text = "";
            if (oyun.Kazanci.HasValue)
            {
                tbKazanci.Text = oyun.Kazanci.Value.ToString(new CultureInfo("tr"));
            }

            tbMaliyeti.Text = "";
            if (oyun.Maliyeti.HasValue)
            {
                tbMaliyeti.Text = oyun.Maliyeti.Value.ToString(new CultureInfo("tr"));
            }

            ddlYili.SelectedValue = oyun.YilId;

            if (oyun.Turler != null && oyun.Turler.Count > 0)
            {
                //foreach (var listItem in lbTurleri.Items) // hata verir
                for (int i = 0; i < lbTurleri.Items.Count; i++)
                {
                    var listItem = lbTurleri.Items[i]; // for
                    var turItem = listItem as TurModel;
                    foreach (var tur in oyun.Turler)
                    {
                        if (turItem.Id == tur.Id)
                        {
                            lbTurleri.SetSelected(lbTurleri.Items.IndexOf(turItem), true);
                            break;
                        }
                    }
                }
            }

            lAdi.Text = oyun.Adi;
            lKazanci.Text = "";
            if (oyun.Kazanci.HasValue)
            {
                lKazanci.Text = oyun.Kazanci.Value.ToString(new CultureInfo("tr"));
            }

            lMaliyeti.Text = "";
            if (oyun.Maliyeti.HasValue)
            {
                lMaliyeti.Text = oyun.Maliyeti.Value.ToString(new CultureInfo("tr"));
            }

            lYili.Text = oyun.YilId.ToString();

            lTurleri.Text = "";
            if (oyun.Turler != null && oyun.Turler.Count > 0)
            {
                foreach (var tur in oyun.Turler)
                {
                    lTurleri.Text += tur.Adi + "\n";
                }

                lTurleri.Text = lTurleri.Text.Trim('\n');
            }
        }
    }
}
