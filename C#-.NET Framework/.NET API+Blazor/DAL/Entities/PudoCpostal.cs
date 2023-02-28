using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PudoCpostal
{
    public int Id { get; set; }

    public int? IdPudo { get; set; }

    public int? IdCpostal { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
