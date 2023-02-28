using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Pudo
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nome { get; set; }

    public string? Morada { get; set; }

    public string? Localidade { get; set; }

    public string? Cpostal { get; set; }

    public int? IdCpostal { get; set; }

    public int? IdPais { get; set; }

    public string? Coordenadas { get; set; }

    public bool? PickupPoint { get; set; }

    public bool? DropPoint { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdCliente { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? HoraAbertura1 { get; set; }

    public DateTime? HoraAbertura2 { get; set; }

    public DateTime? HoraFecho1 { get; set; }

    public DateTime? HoraFecho2 { get; set; }
}
