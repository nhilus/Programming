using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesServicoDet
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public string? Campo { get; set; }

    public string? Valor { get; set; }

    public bool? Activo { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdTipoAgrupa { get; set; }

    public int? IdGrupo { get; set; }

    public string? CausaDev { get; set; }

    public string? Zona { get; set; }

    public int? IdZona { get; set; }
}
