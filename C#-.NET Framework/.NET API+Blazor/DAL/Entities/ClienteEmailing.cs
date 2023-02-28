using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEmailing
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int IdTipoEmailing { get; set; }

    public DateTime? DtInicio { get; set; }

    public int? IdTipoRegularidade { get; set; }

    public string? DiasEspecificos { get; set; }

    public string? EmailDestino { get; set; }

    public DateTime? HoraEnvio { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilRem { get; set; }

    public DateTime? DtRem { get; set; }

    public int? IdCliMorada { get; set; }
}
