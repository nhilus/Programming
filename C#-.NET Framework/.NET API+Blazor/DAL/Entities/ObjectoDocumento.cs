using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ObjectoDocumento
{
    public int Id { get; set; }

    public int IdObjecto { get; set; }

    public int IdTipoObjecto { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? ServerLocation { get; set; }

    public int? Tamanho { get; set; }

    public string? MimeType { get; set; }

    public string? Guid { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdAdos { get; set; }

    public bool? Activo { get; set; }
}
