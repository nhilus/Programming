﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ObjectoDocumentosTipoT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int? IdTipoParent { get; set; }
}