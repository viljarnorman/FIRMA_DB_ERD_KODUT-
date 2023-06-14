using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class Palved
{
    public int Id { get; set; }

    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public int HaruId { get; set; }
    public Haru Haru { get; set; }
    public string Kirjeldus { get; set; } = null!;
    public DateTime Kuupäev { get; set; }
    public String Olek { get; set; } = null!;
}