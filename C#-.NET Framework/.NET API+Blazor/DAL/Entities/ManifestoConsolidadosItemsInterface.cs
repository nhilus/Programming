﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosItemsInterface
{
    public int IdManifestoConsolidadoItem { get; set; }

    public byte IdManifestoConsolidadoItemInterfaceTipo { get; set; }

    public DateTime? DtEnv { get; set; }
}
