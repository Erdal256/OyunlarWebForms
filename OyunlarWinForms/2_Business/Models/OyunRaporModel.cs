using System.ComponentModel;

namespace OyunlarWinForms._2_Business.Models
{
    public class OyunRaporModel
    {
        public int Id { get; set; }

        [DisplayName("Oyun Adı")]
        public string Adi { get; set; }

        [DisplayName("Oyun Maliyeti")]
        public double? Maliyeti { get; set; }

        [DisplayName("Oyun Kazancı")]
        public double? Kazanci { get; set; }

        [DisplayName("Oyun Yılı")]
        public int YilId { get; set; }

        [DisplayName("Oyun Türü")]
        public string TurAdi { get; set; }
        public int TurId { get; set; }
    }
}
