using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TesteAudit
{
    public string? Type { get; set; }

    public string? TableName { get; set; }

    public int? Pk { get; set; }

    public string? FieldName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? DtUltAct { get; set; }

    public short? IdUtilUltAct { get; set; }

    public DateTime? SysUpdateDate { get; set; }

    public string? SysUserName { get; set; }

    public int? SpId { get; set; }

    public string? AlteredData { get; set; }
}
