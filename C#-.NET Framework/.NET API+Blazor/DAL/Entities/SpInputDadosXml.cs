using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SpInputDadosXml
{
    public int Id { get; set; }

    public string? Dados { get; set; }

    public DateTime? DtIntrod { get; set; }
}
