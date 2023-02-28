using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PjInfo
{
    public int Id { get; set; }

    public string? NomeOrigem { get; set; }

    public string? NomeEnvio { get; set; }

    public decimal? Similarity { get; set; }

    public decimal? Confidence { get; set; }

    public decimal? SimilarityNome { get; set; }
}
