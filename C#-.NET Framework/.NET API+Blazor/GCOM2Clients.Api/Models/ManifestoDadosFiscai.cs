using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoDadosFiscai
{
    public int IdMaster { get; set; }

    public string? Empresa { get; set; }

    public string? Nome { get; set; }

    public string? Nif { get; set; }

    public string? Morada { get; set; }

    public string? CodPostal { get; set; }

    public string? Localidade { get; set; }

    public string? SiglaPais { get; set; }

    public string? NomeContacto { get; set; }

    public string? NrTelefone { get; set; }

    public string? Email { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
