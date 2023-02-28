using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteEntidadesEnvio
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int NumeroEnvios { get; set; }

    public int IdPeriodicidade { get; set; }

    public int IdPesoMedio { get; set; }

    public int IdServico { get; set; }

    public int IdRegime { get; set; }
}
