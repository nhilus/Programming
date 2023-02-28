using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosTiposT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public short Sinal { get; set; }

    public bool? Visivel { get; set; }

    public string CodigoFact { get; set; } = null!;

    public bool? PCreditar { get; set; }

    public bool PeriodicidadeCliente { get; set; }

    public string? CodigoSap { get; set; }

    public bool? Activo { get; set; }

    public string? DescCliente { get; set; }

    public bool? IsValidSdd { get; set; }
}
