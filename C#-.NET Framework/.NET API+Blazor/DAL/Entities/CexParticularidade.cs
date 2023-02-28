using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CexParticularidade
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Regra { get; set; }

    public string? CodClienteParceiro { get; set; }

    public string? Cpostal { get; set; }

    public string? Produto { get; set; }

    public int? IdCliMoradaNova { get; set; }

    public int? IdServicoNovo { get; set; }

    public int? IdClasseOrigemNova { get; set; }

    public int? Activo { get; set; }

    public string? Descricao { get; set; }

    public string? CodClienteParceiroWs { get; set; }
}
