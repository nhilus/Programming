﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoScansInterface
{
    public int IdManifestoScan { get; set; }

    public byte IdManifestoScanInterfaceTipo { get; set; }

    public DateTime? DtEnv { get; set; }
}
