
namespace FIRMADB_VN.Models;

public class Töötaja
{
    public int Id { get; set; }
    public string Nimi { get; set; } = null!;
    public int AmetinimetusteAjaluguId { get; set; }
    public AmetinimetusteAjalugu AmetinimetusteAjalugu { get; set; } = null!;
    public int HaruId { get; set; }
    public Haru Haru { get; set; } = null!;
    public int IdKood { get; set; }
    public string Aadress { get; set; } = null!;
    public string ArveldusArve { get; set; } = null!;
    public DateTime TöölepinguAlguseKuupäev { get; set; }
    public DateTime TöölepinguLõpuKuupäev { get; set; }

    public ICollection<Laenutus> Laenutus { get; set; }
    public ICollection<Ligipääsuluba> Ligipääsuluba { get; set; }
    public ICollection<Palved> Palved { get; set; }
    public ICollection<TöötajaLapsSeos> TöötajaLapsSeos { get; set; }
    public ICollection<Puhkused> Puhkused { get; set; }
    public ICollection<Haigusleht> Haigusleht { get; set; }
    public ICollection<Tervisekontroll> Tervisekontroll { get; set; }

}