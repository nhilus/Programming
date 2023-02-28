using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FicheirosImportado
{
    public int Id { get; set; }

    public DateTime DataImport { get; set; }

    public int? IdUtil { get; set; }

    public string? PathFicheiro { get; set; }

    public string? NomeFicheiro { get; set; }

    public int? TamanhoFicheiro { get; set; }

    public DateTime? DataFicheiro { get; set; }

    public string? Tipo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }
}
