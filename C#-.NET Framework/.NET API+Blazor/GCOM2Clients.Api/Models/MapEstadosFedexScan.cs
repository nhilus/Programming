﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MapEstadosFedexScan
{
    public int Id { get; set; }

    public string? EventCode { get; set; }

    public string? Descricao { get; set; }

    public string? ScanCode { get; set; }
}
