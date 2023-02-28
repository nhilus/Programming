using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DepositoCobrancasLog
{
    public int Id { get; set; }

    public int? IdDepositoCobrancas { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public int? IdUtilAlteracao { get; set; }

    public string? MsgAlteracao { get; set; }

    public string? Campo { get; set; }

    public string? Valor { get; set; }

    public DateTime? DtValidacaoMapa { get; set; }
}
