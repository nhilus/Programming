﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoSegurancaAlertaTipoT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? DescCurta { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }
}