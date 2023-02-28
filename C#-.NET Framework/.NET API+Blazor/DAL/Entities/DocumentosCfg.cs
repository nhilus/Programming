﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosCfg
{
    public int Id { get; set; }

    public string Ano { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool Activo { get; set; }
}
