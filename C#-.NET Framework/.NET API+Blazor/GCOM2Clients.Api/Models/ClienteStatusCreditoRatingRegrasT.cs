using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteStatusCreditoRatingRegrasT
{
    public int Id { get; set; }

    public decimal? PotencialIni { get; set; }

    public decimal? PotencialFim { get; set; }

    public int? RatingIni { get; set; }

    public int? RatingFim { get; set; }

    public int? ScoreIni { get; set; }

    public int? ScoreFim { get; set; }

    public bool GeraPedidoCredito { get; set; }

    public decimal? FactorMultCredito { get; set; }

    public int? StCreditoAtribuir { get; set; }

    public decimal? LimiteCreditoAtribuir { get; set; }

    public byte? IdEntidade { get; set; }
}
