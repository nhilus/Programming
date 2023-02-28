using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CobrancaDetalhe
{
    public int Id { get; set; }

    public int IdCobranca { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public string? Observacoes { get; set; }

    public int IdTipoDetalhe { get; set; }

    public int? IdDeptAreaDestino { get; set; }

    public int? IdScan { get; set; }
}
