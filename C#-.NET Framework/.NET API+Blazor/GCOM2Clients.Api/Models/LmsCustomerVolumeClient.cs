using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LmsCustomerVolumeClient
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string AccountName { get; set; } = null!;

    public string? PostalCode { get; set; }

    public string? Year { get; set; }

    public int? Quarter { get; set; }

    public string? DestinationCountryCode { get; set; }

    public string? ProductCode { get; set; }

    public int? Volume { get; set; }

    public DateTime DtUltAct { get; set; }

    public DateTime DtProcessamento { get; set; }
}
