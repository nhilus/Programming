﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteStatusComercialCreditoT
{
    public int Id { get; set; }

    public int IdStatusComercial { get; set; }

    public int IdStatusCredito { get; set; }

    public int IdEntidade { get; set; }

    public bool Auto { get; set; }
}
