using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class OdaOpaTiersCode
{
    public string? Country { get; set; }

    public string? City { get; set; }

    public string? BeginPostalCode { get; set; }

    public string? EndPostalCode { get; set; }

    public string? OpaInternationalParcelServices { get; set; }

    public string? OpaInternationalFreightServices { get; set; }

    public string? OdaInternationalParcelServices { get; set; }

    public string? OdaInternationalFreightServices { get; set; }

    public int? IdPais { get; set; }
}
