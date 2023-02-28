using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesHistoryAudit
{
    public int AuditId { get; set; }

    public int? SaleId { get; set; }

    public string TableName { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? ColumnsUpdated { get; set; }
}
