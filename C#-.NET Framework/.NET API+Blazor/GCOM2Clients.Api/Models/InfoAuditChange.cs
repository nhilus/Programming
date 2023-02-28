using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class InfoAuditChange
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? InsertedXml { get; set; }

    public string? DeletedXml { get; set; }

    public bool AuditLog { get; set; }

    public bool AuditFact { get; set; }

    public bool AuditPortal { get; set; }

    public DateTime CreatedOn { get; set; }
}
