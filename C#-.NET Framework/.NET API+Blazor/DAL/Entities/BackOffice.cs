using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BackOffice
{
    public int Id { get; set; }

    public int? IdParent { get; set; }

    public DateTime DtAbertura { get; set; }

    public int IdUtilAbertura { get; set; }

    public string Observacoes { get; set; } = null!;

    public bool Fechado { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public int? IdCliente { get; set; }

    public int? IdUtilDestino { get; set; }

    public int? IdDepartDestino { get; set; }

    public int? IdAlerta { get; set; }

    public bool Fechadodestino { get; set; }

    public DateTime? Dtfechadodestino { get; set; }

    public bool ApenasFecharOrigem { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdBoffOrig { get; set; }

    public int? IdPerguntaResposta { get; set; }
}
