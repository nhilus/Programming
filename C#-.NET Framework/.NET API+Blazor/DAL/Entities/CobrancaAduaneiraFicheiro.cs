using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CobrancaAduaneiraFicheiro
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? IdUtil { get; set; }

    public string? LocalOrigem { get; set; }

    public string? NomeOrigem { get; set; }

    public string? LocaldDestino { get; set; }

    public string? NomeDestino { get; set; }
}
