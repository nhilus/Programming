using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Contencioso
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public int IdCliente { get; set; }

    public string? Contacto { get; set; }

    public string? Morada { get; set; }

    public string? Telefone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtAbertura { get; set; }

    public short Ano { get; set; }

    public decimal? Capital { get; set; }

    public string? NProcInsolvencia { get; set; }

    public string? NAccaoDecl { get; set; }

    public decimal? JurosAccaoDecl { get; set; }

    public decimal? CustasAccaoDecl { get; set; }

    public string? NInjuncao { get; set; }

    public decimal? JurosInjuncao { get; set; }

    public decimal? CustasInjuncao { get; set; }

    public string? NExecucao { get; set; }

    public decimal? JurosExecucao { get; set; }

    public decimal? CustasExecucao { get; set; }

    public decimal? ProvisaoExecucao { get; set; }

    public int? IdAdvogado { get; set; }

    public decimal? HonorariosAdvogado { get; set; }

    public string? ObsCoface { get; set; }

    public string? ObsTestemunhas { get; set; }

    public decimal? ValorCobrado { get; set; }

    public decimal? ValorCreditado { get; set; }

    public decimal? ValorIncobravel { get; set; }

    public decimal? ValorReduzido { get; set; }

    public int IdFase { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }

    public bool Anulado { get; set; }
}
