using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MapeamentoScanCode
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string? ScanCodeRgl { get; set; }

    public string? EventCode { get; set; }

    public string? ReasonCode { get; set; }

    public string? TextoLivre { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoWeb { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool Activo { get; set; }

    public string? Er { get; set; }

    public string? Sentido { get; set; }
}
