using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserSwap
{
    public int IdHeader { get; set; }

    public int? IdEntidade { get; set; }

    public string? Nome { get; set; }

    public string? Telefone { get; set; }

    public string? Empresa { get; set; }

    public string? Departamento { get; set; }

    public string? Morada { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public int? IdPais { get; set; }

    public string? CodPais { get; set; }

    public string? NumContrib { get; set; }

    public string? NumConta { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdDestinatario { get; set; }

    public int? IdAgrupamento { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUltAct { get; set; }

    public bool? Anulado { get; set; }

    public bool? IdClassDest { get; set; }

    public int? TipoSwap { get; set; }
}
