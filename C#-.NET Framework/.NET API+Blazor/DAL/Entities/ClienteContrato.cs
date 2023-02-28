using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteContrato
{
    public int Id { get; set; }

    public string? UrlContrato { get; set; }

    public string? TipoOportunidad { get; set; }

    public string? TipoMercancia { get; set; }

    public string? TipoMandatoSepa { get; set; }

    public string? TipoCuentaBancaria { get; set; }

    public string? MailReembolso { get; set; }

    public string? IndTipoTarifa { get; set; }

    public string? IndMapaBaremo { get; set; }

    public string? IndEstaAprobada { get; set; }

    public string? ImporteReembolso { get; set; }

    public string? ImporteRecogida { get; set; }

    public string? IdTarifaName { get; set; }

    public string? IdTarifa { get; set; }

    public string? IdeFormaPago { get; set; }

    public string? IdeExterno { get; set; }

    public string? IdeContrato { get; set; }

    public string? IdContactoVenta { get; set; }

    public string? IbanIntracomunitario { get; set; }

    public string? IbanExtracomunitario { get; set; }

    public string? HorarioRecogida { get; set; }

    public string? FrecuenciaRecogida { get; set; }

    public string? FpgReqAutorizacion { get; set; }

    public string? FechActivacion { get; set; }

    public string? EnviosReembolso { get; set; }

    public string? DispersionProductos { get; set; }

    public string? DispersionesEstandar { get; set; }

    public string? DiaPago2 { get; set; }

    public string? DiaPago1 { get; set; }

    public string? DesOferta { get; set; }

    public string? Competidores { get; set; }

    public string? CodSucursalReembolso { get; set; }

    public string? CodSucursalFacturacion { get; set; }

    public string? CodigoMandatoSepa { get; set; }

    public string? CodIbanreembolso { get; set; }

    public string? CodIbanFacturacion { get; set; }

    public string? CodDcReembolso { get; set; }

    public string? CodDcFacturacion { get; set; }

    public string? CodCuentaReembolso { get; set; }

    public string? CodCuentaFacturacion { get; set; }

    public string? CodBicFacturacion { get; set; }

    public string? CodBancoReembolso { get; set; }

    public string? CodBancoFacturacion { get; set; }

    public string? CentroRecogida { get; set; }

    public string? BultosPorExpedicion { get; set; }

    public string? BultosExpedicionEstandar { get; set; }

    public string? Bultos { get; set; }

    public DateTime? DtCriacao { get; set; }

    public string? IdCliente { get; set; }

    public string? Suplementos { get; set; }
}
