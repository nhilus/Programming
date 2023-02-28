using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ExportacaoAgrupamento
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdTipoAgrupa { get; set; }

    public DateTime Data { get; set; }

    public string? Codigo { get; set; }

    public string? Morada { get; set; }

    public string? NomeEmpresa { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
