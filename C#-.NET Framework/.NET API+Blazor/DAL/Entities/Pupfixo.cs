using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Pupfixo
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdTipoProduto { get; set; }

    public int IdZonaPaisDestino { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int IdEntidade { get; set; }

    public int? IdDistribuidor { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdSegmento { get; set; }

    public int NumeroEnvios { get; set; }

    public int NumeroVolumes { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public decimal Peso { get; set; }

    public bool? Segunda { get; set; }

    public bool? Terca { get; set; }

    public bool? Quarta { get; set; }

    public bool? Quinta { get; set; }

    public bool? Sexta { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public string? Observacoes { get; set; }

    public bool? Experiencia { get; set; }

    public DateTime? DtInicioFecho { get; set; }

    public DateTime? DtFimFecho { get; set; }

    public bool? Activo { get; set; }

    public DateTime? DtUltActualizacao { get; set; }

    public int? IdUtilUltActualizacao { get; set; }

    public DateTime? Horadisponivel { get; set; }

    public DateTime? Horafecho { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdRotaDefault { get; set; }

    public bool? StCredito { get; set; }
}
