using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserEstadosLog
{
    public int Id { get; set; }

    public DateTime BckDate { get; set; }

    public int IdParserEstados { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? ScanCode { get; set; }

    public string? Plataforma { get; set; }

    public string? Rota { get; set; }

    public string? Awb { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? Comment { get; set; }

    public string? Signature { get; set; }

    public int? LineIndex { get; set; }

    public string? FileName { get; set; }

    public string? Tipo { get; set; }

    public string? IdRecolhasCep { get; set; }

    public string? Referencia { get; set; }
}
