using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistaSugestaoValorizacoesLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public short IdEntrevistaTipo { get; set; }

    public short IdCriterio { get; set; }

    public int? IdCriterioLog { get; set; }

    public DateTime Data { get; set; }

    public byte IdEntidade { get; set; }

    public object? Valor { get; set; }

    public int Valorizacao { get; set; }

    public DateTime? DtEntrevAnterior { get; set; }
}
