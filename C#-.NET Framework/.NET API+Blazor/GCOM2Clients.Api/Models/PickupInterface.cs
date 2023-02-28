using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PickupInterface
{
    public int IdPickup { get; set; }

    public byte IdPickupInterfaceTipo { get; set; }

    public DateTime? DtEnv { get; set; }
}
