using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesEnviosSuspenso
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? CodRte { get; set; }

    public string? NomeRte { get; set; }

    public string? DirRte { get; set; }

    public string? PobRte { get; set; }

    public string? CodPosNacRte { get; set; }

    public string? PaisIsorte { get; set; }

    public string? NomeDest { get; set; }

    public string? DirDest { get; set; }

    public string? PobDest { get; set; }

    public string? CodPosNacDest { get; set; }

    public string? PaisIsodest { get; set; }

    public int? IdServico { get; set; }

    public int? IdProduto { get; set; }

    public string? RefExp { get; set; }

    public int? Activo { get; set; }
}
