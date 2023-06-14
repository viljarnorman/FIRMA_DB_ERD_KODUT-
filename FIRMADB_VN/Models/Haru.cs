using System;
using System.Collections.Generic;
using FIRMADB_VN.Models;

namespace FIRMADB_VN.Models;

public class Haru
{
    public int Id { get; set; }
    public string HaruNimi { get; set; } = null!;
    public string Aadress { get; set; } = null!;
    public int RegistriKood { get; set; }
    public ICollection<Palved> Palved { get; set; }
    public ICollection<AmetinimetusteNimekiri> AmetinimetusteNimekiri { get; set; }
    public ICollection<LaenutatavInventar> LaenutatavInventar { get; set; }
    public ICollection<Vihjed> Vihjed { get; set; }
    public ICollection<Töötaja> Töötaja { get; set; }
}

