using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EmailRelatoriosRegulare
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int? Idutil { get; set; }

    public string? Sender { get; set; }

    public int? Idcliente { get; set; }

    public string? Recipient { get; set; }

    public string Titulo { get; set; } = null!;

    public string Texto { get; set; } = null!;

    public string Ficheiro { get; set; } = null!;

    public string Formato { get; set; } = null!;

    public string? Params { get; set; }

    public bool? Activo { get; set; }

    public DateTime? Horainicio { get; set; }

    public DateTime? Horafim { get; set; }

    public int? Regularidade { get; set; }

    public string? Dias { get; set; }

    public DateTime? UltHora { get; set; }

    public bool? Workdayonly { get; set; }

    public DateTime? Lastemail { get; set; }

    public bool SendEmpty { get; set; }

    public int MaxSizeKb { get; set; }
}
