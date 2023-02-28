using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CotacoesPickup
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdPickup { get; set; }

    public int IdCotacao { get; set; }
}
