using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class InterfaceDadosPend
{
    public short IdInterfaceTipo { get; set; }

    public short IdInterfaceDestino { get; set; }

    public int IdRegisto { get; set; }

    public DateTime? DtIntrod { get; set; }
}
