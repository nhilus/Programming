using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BusinessPlan
{
    public int Id { get; set; }

    public int IdZona { get; set; }

    public decimal? BpImp { get; set; }

    public decimal? BpExpAe { get; set; }

    public decimal? BpExpTs { get; set; }

    public int? Criterio { get; set; }

    public DateTime? Data { get; set; }

    public string Fy { get; set; } = null!;

    public int IdEntidade { get; set; }
}
