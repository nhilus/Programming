using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DlinkDelivery
{
    public int PkeyDelivery { get; set; }

    public int? ShipmentKey { get; set; }

    public string? InvoiceNum { get; set; }

    public string? TrackingId { get; set; }

    public int? PickupType { get; set; }

    public string? OriginId { get; set; }

    public string? DestinationId { get; set; }

    public string? DeliveryType { get; set; }

    public string? Exception { get; set; }

    public DateTime? AttemptDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Signature { get; set; }

    public string? Schedule { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusMessage { get; set; }

    public string? ReleasedBy { get; set; }

    public string? DeliveryAddr { get; set; }

    public string? RequestRef { get; set; }

    public byte[]? SignatureImage { get; set; }

    public string? ServiceLevel { get; set; }

    public string? Disposition { get; set; }
}
