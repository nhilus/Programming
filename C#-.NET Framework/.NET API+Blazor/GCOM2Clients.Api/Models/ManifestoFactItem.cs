using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoFactItem
{
    public int IdManifestoItem { get; set; }

    public int? IdManifesto { get; set; }

    public string? Awb { get; set; }

    public byte? IdEntidade { get; set; }

    public int? IdScan { get; set; }

    public bool Activo { get; set; }

    public string? Descricao { get; set; }

    public short? IdServicoDet { get; set; }

    public int? IdTarifa { get; set; }

    public byte? IdTipoAgrupa { get; set; }

    public byte? IdTipoAgrupaRep { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? DtValor { get; set; }

    public bool ValorManual { get; set; }

    public short? IdUtilValor { get; set; }

    public decimal? ValorRef { get; set; }

    public decimal? PercDesconto { get; set; }

    public decimal? CustoPrevisto { get; set; }

    public byte? IdTipoIva { get; set; }

    public string? CodIva { get; set; }

    public byte? IdIvareg { get; set; }

    public bool ExpToFact { get; set; }

    public DateTime? DtExpToFact { get; set; }

    public bool Fact { get; set; }

    public DateTime? DtFact { get; set; }

    public DateTime? DtUltAct { get; set; }

    public short? IdUtilUltAct { get; set; }

    public bool? EmErroValorizacao { get; set; }

    public bool? ReqValidacao { get; set; }

    public bool? IsValidToFact { get; set; }

    public int? IdUtilIsValidToFact { get; set; }

    public DateTime? DtIsValidToFact { get; set; }

    public int? IdMoeda { get; set; }
}
