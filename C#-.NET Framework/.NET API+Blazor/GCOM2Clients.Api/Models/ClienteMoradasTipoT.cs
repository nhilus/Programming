﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteMoradasTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }
}