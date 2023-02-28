using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EmpresasRatingsLog
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public string NrContrib { get; set; } = null!;

    public byte? Rating { get; set; }

    public byte? Score { get; set; }

    public DateTime Data { get; set; }

    public string? Observacoes { get; set; }
}
