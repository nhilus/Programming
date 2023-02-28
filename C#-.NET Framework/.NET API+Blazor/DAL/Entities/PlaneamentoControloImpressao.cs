using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PlaneamentoControloImpressao
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? IdRota { get; set; }

    public string? Tipo { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdRecolha { get; set; }

    public int? NumDocAdos { get; set; }

    public bool? Impresso { get; set; }

    public DateTime? Dtimpresso { get; set; }

    public int? IdUtilImp { get; set; }
}
