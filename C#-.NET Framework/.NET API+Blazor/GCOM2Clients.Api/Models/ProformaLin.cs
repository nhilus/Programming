using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProformaLin
{
    public int Id { get; set; }

    public int IdProformaCab { get; set; }

    public int? IdCabFactura { get; set; }

    public int Lin { get; set; }

    public int? NumVolumes { get; set; }

    public int? IdManifesto { get; set; }

    public string? Awbnumber { get; set; }

    public decimal? Peso { get; set; }

    public decimal? PesoVol { get; set; }

    public decimal? M3 { get; set; }

    public string? Dimensoes { get; set; }

    public string? DestCpostal { get; set; }

    public int? DestIdPais { get; set; }

    public string? DestPais { get; set; }

    public decimal Quantidade { get; set; }

    public decimal ValorUnitario { get; set; }

    public int? IdTipoIva { get; set; }

    public decimal TaxaIva { get; set; }

    public decimal? ValorCiva { get; set; }

    public decimal ValorSiva { get; set; }

    public decimal ValorIva { get; set; }

    public string? Observacoes { get; set; }

    public int? IdTarifa { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public int? IdServicoDet { get; set; }

    public string? CodIva { get; set; }

    public int? IdMoeda { get; set; }

    public decimal? Cambio { get; set; }

    public bool? Spot { get; set; }

    public int? IdTipoProduto { get; set; }

    public int? IdUtilAssociacaoManif { get; set; }

    public DateTime? DtAssociacaoManif { get; set; }

    public int? OrigIdPais { get; set; }

    public string? OrigCpostal { get; set; }
}
