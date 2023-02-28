using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class InterfaceDadosLog
{
    public int Id { get; set; }

    public short IdInterfaceTipo { get; set; }

    public short IdInterfaceDestino { get; set; }

    public int IdRegisto { get; set; }

    public DateTime DtEnv { get; set; }
}
