using AutoMapper.Configuration.Annotations;

namespace BAL.Models;

public partial class UtilizadorActivo
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public int? Telemovel { get; set; }
    public string? Email { get; set; }
    public int? IdGrupo { get; set; }
    public bool RespGrupo { get; set; }
    public int IdPlataforma { get; set; }
    public int IdPais { get; set; }
    public int? IdAgente { get; set; }
    public int IdEntidade { get; set; }
    public int? IdDistribuidor { get; set; }
    public bool? Visivel { get; set; }
    public bool? Activo { get; set; }
    public bool PermLoginDev { get; set; }
    public string? NumCartaConducao { get; set; }
    public DateTime? ValCartaConducao { get; set; }
    public DateTime? ValLicencaTransporte { get; set; }
    public DateTime? ValRegistoCriminal { get; set; }
}


