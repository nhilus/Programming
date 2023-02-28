using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConsumosClatLog
{
    public int? IdExportacao { get; set; }

    public DateTime? DataEnvioCliente { get; set; }

    public string? DataServico { get; set; }

    public string? Objecto { get; set; }

    public string? TipoExpedicao { get; set; }

    public string? Ref { get; set; }

    public string? TipoServico { get; set; }

    public int? Expedidor { get; set; }

    public string? Destinatario { get; set; }

    public string? Morada { get; set; }

    public string? Localidade { get; set; }

    public string? CodPostalDest { get; set; }

    public string? Observacoes { get; set; }

    public string? ContactoDestino { get; set; }

    public decimal? Peso { get; set; }

    public int? Nvolumes { get; set; }

    public string? Recolha { get; set; }

    public string? MoradaRecolha { get; set; }

    public string? LocalidadeRecolha { get; set; }

    public string? CodPostalRecolha { get; set; }

    public string? ContactoRecolha { get; set; }

    public int? IdManifesto { get; set; }
}
