using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PlataformaT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string CodigoFact { get; set; } = null!;

    public int? IdPais { get; set; }

    public int? IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public int? Ordem { get; set; }

    public int? IdClienteReembolsos { get; set; }

    public int? IdCliMoradaReembolsos { get; set; }

    public string? SapTipoDoc { get; set; }

    public int? IdClienteDevgr { get; set; }

    public int? IdCliMoradaDevgr { get; set; }

    public string? CodCurto { get; set; }

    public string? UrsaCode { get; set; }

    public string? UserCosmos { get; set; }

    public byte? IdPlataformaReg { get; set; }

    public string? Email { get; set; }
}
