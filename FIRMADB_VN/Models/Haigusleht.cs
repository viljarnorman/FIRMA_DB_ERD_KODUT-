using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace FIRMADB_VN.Models;

public class Haigusleht
{
    public int Id { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public string LiikHaiguslehtHooldusleht { get; set; } = null!;
    public int HaigusleheKestvusePikkus { get; set; }
    public DateTime HaigusleAvamiseKuupäev { get; set; }
    public DateTime HaigusleLõpetamiseKuupäev { get; set; }
}