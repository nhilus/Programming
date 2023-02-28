using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserLogTemp
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public DateTime? DtIntrod { get; set; }

    public string? Awb { get; set; }

    public bool? ImpManifesto { get; set; }

    public bool? ExpManifesto { get; set; }

    public bool? RefCliDuplicada { get; set; }

    public bool? AwbDuplicada { get; set; }

    public bool? Erro { get; set; }

    public int? IdRecolha { get; set; }

    public int? IdHeader { get; set; }

    public int? IdDetails { get; set; }

    public string? ExceptionMessage { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
