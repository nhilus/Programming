using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserCrossDocking
{
    public string? NomeEmpresa { get; set; }

    public string? RefCli { get; set; }

    public DateTime? DtEncomenda { get; set; }

    public DateTime? DtAceitacao { get; set; }

    public int? LinhaPc { get; set; }

    public string? DescricaoProduto { get; set; }

    public double? Quantidade { get; set; }

    public string? UnidMedida { get; set; }

    public string? CentroCusto { get; set; }

    public string? Fornecedor { get; set; }

    public string? NomeRequsitante { get; set; }

    public string? Departamento { get; set; }

    public string? Endereco1 { get; set; }

    public string? Endereco2 { get; set; }

    public string? Endereco3 { get; set; }

    public string? Endereco4 { get; set; }

    public string? Cidade { get; set; }

    public string? Cp { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtConsolidacao { get; set; }

    public bool? Anulado { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int Id { get; set; }

    public int? IdMorada { get; set; }
}
