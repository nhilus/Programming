namespace BAL.Models;

public partial class UtilizadorModel
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int? Extensao { get; set; }

    public int? Telemovel { get; set; }

    public string? Email { get; set; }

    public DateTime DtInicioActividade { get; set; }

    public DateTime? DtFimActividade { get; set; }

    public int? IdGrupo { get; set; }

    public bool RespGrupo { get; set; }

    public int IdPlataforma { get; set; }

    public int IdPais { get; set; }

    public int? IdAgente { get; set; }

    public int IdEntidade { get; set; }

    public int? IdDistribuidor { get; set; }

    public decimal? VencimentoAnual { get; set; }

    public bool? DestinatarioReclamacoes { get; set; }

    public bool? DestinatarioCrm { get; set; }

    public bool DestinatarioCrmtrans { get; set; }

    public bool RemetenteCrmtrans { get; set; }

    public bool? DestinatarioBoff { get; set; }

    public bool DestinatarioBoffTrans { get; set; }

    public bool RemetenteBoffTrans { get; set; }

    public bool AssociaClientesExcep { get; set; }

    public bool EnviaConversa { get; set; }

    public bool EnviaConversaPrio { get; set; }

    public bool? RecebeConversa { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool PermLoginDev { get; set; }

    public string? NumCartaConducao { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public string? CodIpbrick { get; set; }

    public string? Ldaplogin { get; set; }

    public DateTime? ValCartaConducao { get; set; }

    public DateTime? ValLicencaTransporte { get; set; }

    public DateTime? ValRegistoCriminal { get; set; }

    public bool? TelnetAccess { get; set; }

}
