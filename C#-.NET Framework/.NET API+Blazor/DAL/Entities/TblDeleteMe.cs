using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TblDeleteMe
{
    public string? MasterNumber { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtEnvio { get; set; }
}
