using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserRecolha
{
    public int Id { get; set; }

    public DateTime CreationDate { get; set; }

    public string? FileName { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public int IdEntidade { get; set; }

    public DateTime DtPup { get; set; }

    public string? Referencia { get; set; }

    public string? RefOrigem { get; set; }

    public string? Nome { get; set; }

    public string? Empresa { get; set; }

    public string? Telefone { get; set; }

    public string? Morada { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public int? IdPais { get; set; }

    public int? IdServico { get; set; }

    public int? IdTipoProduto { get; set; }

    public int? NumVolumes { get; set; }

    public decimal? Peso { get; set; }

    public DateTime? HoraDisponivel { get; set; }

    public DateTime? HoraFecho { get; set; }

    public string? Observacoes { get; set; }

    public int? IdLocalPagamento { get; set; }

    public string? CamposObrigatorios { get; set; }

    public string? NomeDestinatario { get; set; }

    public string? EmpresaDestinatario { get; set; }

    public string? TelefoneDestinatario { get; set; }

    public string? MoradaDestinatario { get; set; }

    public string? CpostalDestinatario { get; set; }

    public string? LocalidadeDestinatario { get; set; }

    public int? IdPaisDestinatario { get; set; }

    public bool? CheckReferencia { get; set; }

    public string? NumEnvio { get; set; }

    public int? LineIndex { get; set; }

    public string? Nifpagamento { get; set; }

    public int? IdPaisPagamento { get; set; }

    public string? EmailNotificacao { get; set; }
}
