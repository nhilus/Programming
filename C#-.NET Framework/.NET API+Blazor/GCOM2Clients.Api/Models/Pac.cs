using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Pac
{
    public int Id { get; set; }

    public int? IdReclamacao { get; set; }

    public DateTime DtCriacao { get; set; }

    public int IdUtilCriacao { get; set; }

    public string? ObsNaoConformidade { get; set; }

    public int? IGCOM2UsersertaNaoConformidade { get; set; }

    public int? IdUtilDestino { get; set; }

    public string? ObsAccaoCorrectiva { get; set; }

    public DateTime? DtImplementacaoAccaoCorrectiva { get; set; }

    public DateTime? DtIntrodAccaoCorrectiva { get; set; }

    public int? IGCOM2UsersertaAccaoCorrectiva { get; set; }

    public int? IdCausaRaiz { get; set; }

    public int? IdTipoAccaoCorrectiva { get; set; }

    public DateTime? DtAvaliacaoPrevista { get; set; }

    public int? IdUtilIntrodDtAvaliacaoPrevista { get; set; }

    public DateTime? DtIntrodDtAvaliacaoPrevista { get; set; }

    public int? IGCOM2UsersertaAvaliacao { get; set; }

    public DateTime? DtAvaliacao { get; set; }

    public string? ObsAvaliacao { get; set; }

    public int? IdUtilAvaliacao { get; set; }

    public DateTime? DtIntrodAvaliacao { get; set; }

    public bool? Eficaz { get; set; }

    public int? IGCOM2UsersertaEficacia { get; set; }

    public int? IdPacReimplementa { get; set; }

    public int IdEntidade { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? DtAnulado { get; set; }

    public int? IdUtilAnulado { get; set; }
}
