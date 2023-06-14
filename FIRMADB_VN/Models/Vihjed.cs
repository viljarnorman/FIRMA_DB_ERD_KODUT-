using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class Vihjed
{
    public int Id { get; set; }
    public string Kirjeldus { get; set; } = null!;
    public DateTime Kuupäev { get; set; }
    public string Olek { get; set; } = null!;
    public int HaruId { get; set; }
    public Haru Haru { get; set; } = null!;
}