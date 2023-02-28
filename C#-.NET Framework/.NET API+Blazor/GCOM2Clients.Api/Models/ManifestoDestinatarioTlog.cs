using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoDestinatarioTlog
{
    public int IdTrigger { get; set; }

    public DateTime? DtTrigger { get; set; }

    public int IdMaster { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public string? Nome { get; set; }

    public string? Telefone { get; set; }

    public string? Empresa { get; set; }

    public string? Departamento { get; set; }

    public string? Morada { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public short? IdPais { get; set; }

    public string? NrContrib { get; set; }

    public string? NumConta { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdDestinatario { get; set; }

    public int? IdAgrupamento { get; set; }

    public short? IdPlataforma { get; set; }

    public DateTime DtUltAct { get; set; }

    public short IdUtilUltAct { get; set; }

    public string? Email { get; set; }
}
