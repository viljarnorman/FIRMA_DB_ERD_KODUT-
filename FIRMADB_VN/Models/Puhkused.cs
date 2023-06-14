using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIRMADB_VN.Models;

public class Puhkused
{
    public int Id { get; set; }
    public int TöötajaId { get; set; }
    public Töötaja Töötaja { get; set; } = null!;
    public string PuhkuseLiik { get; set; } = null!;
    public int PuhkusePikkus { get; set; }
    public DateTime PuhkuseAlguseKuupäev { get; set; }
    public DateTime PuhkuseLõpuKuupäev { get; set; }
}