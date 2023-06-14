namespace FIRMADB_VN.Models;

public class Laenutus
{
    public int Id { get; set; }
    public string InventariNimetus { get; set; }
    public int LaenutatavInventarId { get; set; }
    public LaenutatavInventar LaenutatavInventar { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public DateTime LaenutuseAlgus { get; set; }
    public DateTime LaenutuseLõpp { get; set; }

}