using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Nsplataforma
{
    public int NsplataformasId { get; set; }

    public int IdPlataforma { get; set; }

    public int? IdServico { get; set; }

    public string Regiao { get; set; } = null!;

    public int NivelServico { get; set; }
}
