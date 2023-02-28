using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoFedexGrasp
{
    public int Id { get; set; }

    public string? HdVisaTransactionCd { get; set; }

    public DateTime? HdGmtdt { get; set; }

    public TimeSpan? HdGmttm { get; set; }

    public string? MdeAirbillNbr { get; set; }

    public string? MdeOrigLoc { get; set; }

    public string? MdeDestLoc { get; set; }

    public string? MdeConsigneeNm { get; set; }

    public string? MdeConsigneeCompany { get; set; }

    public string? MdeConsigneeAddress1 { get; set; }

    public string? MdeConsigneeAddress2 { get; set; }

    public string? MdeConsigneeCity { get; set; }

    public string? MdeConsigneeStateCd { get; set; }

    public string? MdeConsigneeCountryCd { get; set; }

    public string? MdeConsigneePostalCd { get; set; }

    public string? MdeConsigneePhone { get; set; }

    public string? MdeTypeService { get; set; }

    public string? MdeDangGoodsFlg { get; set; }

    public int? MdeTotPieces { get; set; }

    public decimal? MdeTotWeight { get; set; }

    public string? MdeCurrType { get; set; }

    public decimal? MdeTotCustomsVal { get; set; }

    public string? MdeGoodsClassCd { get; set; }

    public string? MdeFormTypeCd { get; set; }

    public string? MdeAmsMawbNbr { get; set; }

    public decimal? MdeFreightChargeAmt { get; set; }

    public int? MdeHandlingUnitQty { get; set; }

    public string? MdeDescription { get; set; }

    public string? MdeDestCurrType { get; set; }

    public decimal? MdeDestTotCustomsAmt { get; set; }

    public decimal? MdeDnldLocTotCustomsAmt { get; set; }

    public string? MdeServiceBase { get; set; }

    public string? MdePackagingType { get; set; }

    public string? SepUidNbr { get; set; }

    public long? ExtraInteger1 { get; set; }

    public string? MdeShipperNm { get; set; }

    public string? MdeShipperCompany { get; set; }

    public string? MdeShipperAddress1 { get; set; }

    public string? MdeShipperAddress2 { get; set; }

    public string? MdeShipperCity { get; set; }

    public string? MdeShipperStateCd { get; set; }

    public string? MdeShipperCountryCd { get; set; }

    public string? MdeShipperPostalCd { get; set; }

    public string? MdeShipperPhone { get; set; }

    public DateTime? MdeShipDt { get; set; }

    public string? MdeCountryOfOrigin { get; set; }

    public string? MdeCountryOfExport { get; set; }

    public string? MdeWgtUomCd { get; set; }

    public string? MdeBillToFlg { get; set; }

    public string? MdeDutiableFlg { get; set; }

    public string? MdeBillDtyFlg { get; set; }

    public string? MpsCrossRefNbr { get; set; }

    public string? ExtraString5 { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool Dirty { get; set; }

    public string? MdeShipperAccountNbr { get; set; }

    public string? MdeConsigneeAccountNbr { get; set; }

    public string? MdeBillToAccount { get; set; }

    public string? MdeBillDtyAccountNbr { get; set; }
}
