using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupDocumento
{
    public int Id { get; set; }

    public int? IdPickup { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? ServerLocation { get; set; }

    public int? Tamanho { get; set; }

    public string? MimeType { get; set; }

    public string? Guid { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
