using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PerguntasResposta
{
    public int Id { get; set; }

    public string Awb { get; set; } = null!;

    public int IdCodigo { get; set; }

    public string? Scancode { get; set; }

    public string? Obs { get; set; }

    public DateTime Data { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdEntidade { get; set; }

    public int IdDistribuidor { get; set; }

    public int? IdOwner { get; set; }

    public byte EnviadoInterface { get; set; }

    public DateTime? DtEnviadoIterface { get; set; }

    public int IdUtilInsert { get; set; }

    public DateTime DtInsert { get; set; }

    public bool Tratada { get; set; }

    public DateTime? DtTratada { get; set; }

    public int? IdOrigem { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdCliente { get; set; }
}
