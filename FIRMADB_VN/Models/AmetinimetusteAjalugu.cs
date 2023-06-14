using System.ComponentModel.DataAnnotations.Schema;


namespace FIRMADB_VN.Models;

public class AmetinimetusteAjalugu
{
    public int Id { get; set; }
    public string Ametinimetused { get; set; } = null!;
    public int AmetinimetusteNimekiriId { get; set; }
    public AmetinimetusteNimekiri AmetinimetusteNimekiri { get; set; } = null!;
    public DateTime AmetisseMääramiseKuupäev { get; set; }
    public int AmetisOldudAeg { get; set; }
    public ICollection<Töötaja> Töötaja { get; set; }
}