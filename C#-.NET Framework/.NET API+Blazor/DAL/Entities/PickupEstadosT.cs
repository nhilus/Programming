using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupEstadosT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int? Ordem { get; set; }

    public bool? Anulado { get; set; }

    public bool? Planeado { get; set; }

    public bool? Comunicado { get; set; }

    public bool? CommPda { get; set; }

    public bool? CommMotorista { get; set; }

    public bool? DevolvidoPda { get; set; }

    public bool? Tentado { get; set; }

    public bool? Efectuado { get; set; }

    public bool? Recolhido { get; set; }

    public bool? Tratar { get; set; }

    public DateTime? Validade { get; set; }

    public decimal? ValidadeNum { get; set; }

    public string? Imagem { get; set; }

    public DateTime? DelayUrgente { get; set; }

    public string? ImagemUrgente { get; set; }
}
