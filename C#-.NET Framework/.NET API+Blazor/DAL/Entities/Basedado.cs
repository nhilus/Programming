using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Basedado
{
    public double? Ean { get; set; }

    public double? YesAccountNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? Country { get; set; }

    public string? Currency { get; set; }

    public DateTime? AccountCreationDate { get; set; }

    public string? ActiveOnIms { get; set; }

    public string? ActiveOnYes { get; set; }

    public double? Vatnumber { get; set; }

    public string? TransitionedToEPrs { get; set; }

    public string? PhysicalAddress { get; set; }

    public string? EmailAddress { get; set; }

    public string? IntlOlRateScale { get; set; }

    public string? MaxDiscLoaded { get; set; }

    public string? DomesticRates { get; set; }

    public string? CreditTerms { get; set; }
}
