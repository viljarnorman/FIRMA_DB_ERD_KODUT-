using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class AmetinimetusteNimekiri
{
    public int Id { get; set; }
    public string Ametinimetused { get; set; } = null!;
    public int HaruId { get; set; }
    public Haru Haru { get; set; } = null!;
    public ICollection<Ligipääsuluba> Ligipääsuluba { get; set; }
    public ICollection<AmetinimetusteAjalugu> AmetinimetusteAjalugu { get; set; }

}