using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteMovContum
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string NumDoc { get; set; } = null!;

    public string DebCred { get; set; } = null!;

    public decimal Valor { get; set; }

    public DateTime DataDoc { get; set; }

    public DateTime DataVencimento { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string TipoDoc2 { get; set; } = null!;

    public bool ExportSdd { get; set; }

    public DateTime? DtExportSdd { get; set; }

    public int? IdUtilExportSdd { get; set; }

    public bool FechadoSap { get; set; }

    public DateTime? DtFechadoSap { get; set; }
}
