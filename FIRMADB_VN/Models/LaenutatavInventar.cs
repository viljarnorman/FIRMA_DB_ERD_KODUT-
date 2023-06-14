using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace FIRMADB_VN.Models;

public class LaenutatavInventar
{
    public int Id { get; set; }
    public string InventariNimetus { get; set; } = null!;
    public int HaruId { get; set; }
    public Haru Haru { get; set; } = null!;
    public string Kirjeldus { get; set; } = null!;
    public ICollection<Laenutus> Laenutus { get; set; }
}