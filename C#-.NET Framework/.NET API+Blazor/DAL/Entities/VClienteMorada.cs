using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VClienteMorada
{
    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public string NomeCliente { get; set; } = null!;

    public string? NrContrib { get; set; }

    public int IdTipoEntidade { get; set; }

    public decimal LimiteCredito { get; set; }

    public decimal? LimiteCreditoAdua { get; set; }

    public decimal VolumeVendas { get; set; }

    public string? CodContab { get; set; }

    public int? IdTipoAbc { get; set; }

    public int IdCliMorada { get; set; }

    public int IdStComercial { get; set; }

    public int IdStCredito { get; set; }

    public int? IdEquipaComercial { get; set; }

    public int? IdTipoCliente { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public string? Nome { get; set; }

    public string? Morada { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public int? IdPais { get; set; }

    public bool? IsMoradaDefault { get; set; }

    public TimeSpan? HoraDisponivel { get; set; }

    public TimeSpan? HoraFecho { get; set; }

    public string? NumConta { get; set; }

    public int IdUtilResp { get; set; }

    public string NomeContactoDef { get; set; } = null!;

    public long? Telefone { get; set; }

    public long? Fax { get; set; }

    public string? Email { get; set; }

    public bool IsGlobalAccount { get; set; }

    public bool TemSisShip { get; set; }

    public bool? IsMoradaFact { get; set; }

    public bool GrupoRangel { get; set; }
}
