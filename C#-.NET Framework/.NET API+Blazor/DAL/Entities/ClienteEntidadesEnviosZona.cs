using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEntidadesEnviosZona
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdRegime { get; set; }

    public int IdServico { get; set; }

    public int Percentagem { get; set; }

    public int IdZonaPais { get; set; }
}
