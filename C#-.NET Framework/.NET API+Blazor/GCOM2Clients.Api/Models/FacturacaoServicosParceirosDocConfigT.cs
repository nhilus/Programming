using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FacturacaoServicosParceirosDocConfigT
{
    public int Id { get; set; }

    public byte IdEntidade { get; set; }

    public int IdRegime { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public int IdDepartamentoDoc { get; set; }

    public int IdTipoDoc { get; set; }

    public int? IdProdutoTipo { get; set; }

    public int IdServicoDet { get; set; }

    public string TextoDescricao { get; set; } = null!;

    public int? IdTipoIva { get; set; }

    public string? CodIva { get; set; }
}
