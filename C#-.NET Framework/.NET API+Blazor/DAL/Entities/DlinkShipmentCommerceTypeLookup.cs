﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DlinkShipmentCommerceTypeLookup
{
    public string Id { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Version3 { get; set; }
}
