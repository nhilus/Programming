using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Destinatario
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public string? Nome { get; set; }

    public string? Morada { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public string? Telefone { get; set; }

    public string? Nif { get; set; }

    public bool PropCli { get; set; }

    public int? IdClassDest { get; set; }

    public int? IdPais { get; set; }

    public string? Localidade { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Contacto { get; set; }
}
