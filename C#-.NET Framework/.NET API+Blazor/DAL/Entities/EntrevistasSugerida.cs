using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistasSugerida
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public byte IdEntidade { get; set; }

    public int IdCliMorada { get; set; }

    public DateTime Data { get; set; }

    public byte IdMotivo { get; set; }

    public decimal ValorMotivo { get; set; }

    public decimal PesoMotivo { get; set; }

    public decimal ValorPesado { get; set; }

    public short? IdUtilPrevisto { get; set; }

    public DateTime? DtAgendada { get; set; }

    public int? IdEntrevista { get; set; }

    public DateTime? DtEfectuada { get; set; }
}
