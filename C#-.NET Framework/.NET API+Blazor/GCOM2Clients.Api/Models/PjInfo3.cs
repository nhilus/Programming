using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PjInfo3
{
    public int Id { get; set; }

    public string? NomeOrigem { get; set; }

    public string? NomeEnvio { get; set; }

    public string? MoradaOrigem { get; set; }

    public string? MoradaEnvioExp { get; set; }

    public string? MoradaEnvioDest { get; set; }

    public decimal? Similarity { get; set; }

    public decimal? Confidence { get; set; }

    public decimal? SimilarityNomeOuMorada { get; set; }

    public int? IdMaster { get; set; }
}
