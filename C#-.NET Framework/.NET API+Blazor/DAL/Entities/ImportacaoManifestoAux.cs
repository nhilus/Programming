using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoManifestoAux
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? MasterNumber { get; set; }

    public string? MasterFormId { get; set; }

    public string AwbNumber { get; set; } = null!;

    public string? AwbFormId { get; set; }

    public string? EstacaoOrigem { get; set; }

    public string? EstacaoDestino { get; set; }

    public int? IdEstacaoDestino { get; set; }

    public string? PaisOrigem { get; set; }

    public int? IdPaisOrigem { get; set; }

    public string? PaisExportacao { get; set; }

    public DateTime? DataOrigem { get; set; }

    public string? RemTelefone { get; set; }

    public string? RemEmpresa { get; set; }

    public string? RemResponsavel { get; set; }

    public string? RemMorada { get; set; }

    public string? RemLocalidade { get; set; }

    public string? RemEstado { get; set; }

    public string? RemPais { get; set; }

    public int? RemIdPais { get; set; }

    public string? RemCpostal { get; set; }

    public int? IdCliente { get; set; }

    public string? DesTelefone { get; set; }

    public string? DesEmpresa { get; set; }

    public string? DesResponsavel { get; set; }

    public string? DesMorada { get; set; }

    public string? DesLocalidade { get; set; }

    public string? DesEstado { get; set; }

    public string? DesPais { get; set; }

    public string? DesCpostal { get; set; }

    public string? ServiceType { get; set; }

    public string? TipoProduto { get; set; }

    public int? IdTipoProduto { get; set; }

    public string? DangerousGoods { get; set; }

    public string? BillTc { get; set; }

    public int? NumeroPacotes { get; set; }

    public decimal? PesoTotal { get; set; }

    public string? Moeda { get; set; }

    public decimal? ValorTotal { get; set; }

    public string? Descricao { get; set; }

    public bool? DutyDue { get; set; }

    public bool? Cflag { get; set; }

    public decimal? ValorCarriage { get; set; }

    public string? BillDt { get; set; }

    public string? Vatnumber { get; set; }

    public string? DataDownload { get; set; }

    public string? Extracted { get; set; }

    public string? AwbCategoryCustoms { get; set; }

    public string? StatusGraspCsp { get; set; }

    public string? Status { get; set; }

    public bool? TxBack { get; set; }

    public string? DateUpdated { get; set; }

    public string? VisaRoute { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? FlightDestination { get; set; }

    public bool? Dirty { get; set; }

    public DateTime? DataVerifSf { get; set; }

    public bool? Enviado { get; set; }

    public decimal? TransportCharges { get; set; }

    public int IdEntidade { get; set; }

    public int? IdDistribuidor { get; set; }

    public int? IdServico { get; set; }

    public int? IdDesCpostal { get; set; }
}
