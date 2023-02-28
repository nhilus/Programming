using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorDistribuidore
{
    public int Id { get; set; }

    public int IdUtil { get; set; }

    public int IdDistribuidor { get; set; }
}
