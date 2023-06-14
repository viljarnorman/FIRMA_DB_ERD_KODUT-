using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class Laps
{
    public int Id { get; set; }
    public string Nimi { get; set; } = null!;
    public int Age { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public ICollection<TöötajaLapsSeos> TöötajaLapsSeos { get; set; }
}