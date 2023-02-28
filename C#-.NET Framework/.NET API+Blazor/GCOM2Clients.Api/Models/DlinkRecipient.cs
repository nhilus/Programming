using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DlinkRecipient
{
    public int PkeyRecipient { get; set; }

    public int? ShipmentKey { get; set; }

    public string? InvoiceNum { get; set; }

    public string? TrackingId { get; set; }

    public string? Account { get; set; }

    public string? Contact { get; set; }

    public string? Company { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }
}
