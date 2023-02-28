using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ViewSapbwVenda
{
    public int? Nif { get; set; }

    public decimal? Venda { get; set; }

    public string? DtdocD { get; set; }

    public string? DtdocT { get; set; }
}
