using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CamposAuditM
{
    public int Id { get; set; }

    public string? Campo { get; set; }

    public string? Descricao { get; set; }

    public int? Activo { get; set; }

    public string? Tabela { get; set; }

    public string? Typeformat { get; set; }

    public string? Datatype { get; set; }
}
