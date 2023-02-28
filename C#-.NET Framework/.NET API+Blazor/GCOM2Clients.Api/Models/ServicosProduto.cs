using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosProduto
{
    public int Id { get; set; }

    public DateTime? DtInicio { get; set; }

    public byte IdServico { get; set; }

    public byte IdRegime { get; set; }

    public short IdProduto { get; set; }

    public bool? Activo { get; set; }

    public bool? Visivel { get; set; }

    public decimal? PesoMin { get; set; }

    public decimal? PesoMax { get; set; }

    public decimal? PesoMinFact { get; set; }

    public short IdProdutoFact { get; set; }

    public decimal? PesoMinFactPorVol { get; set; }
}
