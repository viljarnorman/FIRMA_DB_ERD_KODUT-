using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class Tervisekontroll
{
    public int Id { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public DateTime SooritamiseKuupäev { get; set; }
    public DateTime KehtivuseLõpp { get; set; }
    public string Piirangud { get; set; } = null!;
    public string Abivahendid { get; set; } = null!;

}