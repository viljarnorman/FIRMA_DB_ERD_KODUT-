using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class TöötajaLapsSeos
{
    public int Id { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public int LapsId { get; set; }
    public Laps Laps { get; set; } = null!;
}