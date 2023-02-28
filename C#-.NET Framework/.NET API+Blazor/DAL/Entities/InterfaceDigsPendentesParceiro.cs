using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class InterfaceDigsPendentesParceiro
{
    public int Id { get; set; }

    public string? FileLocation { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdParceiro { get; set; }
}
