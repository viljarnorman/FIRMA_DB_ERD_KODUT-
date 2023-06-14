using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace FIRMADB_VN.Models;

public class Ligipääsuluba
{
    public int Id { get; set; }
    public int AmetinimetusteNimekiriId { get; set; }
    public AmetinimetusteNimekiri AmetinimetusteNimekiri { get; set; } = null!;
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public string Kirjeldus { get; set; } = null!;
    public DateTime KehtivuseAlgus { get; set; }
    public DateTime KehtivuseLõpp { get; set; }
}