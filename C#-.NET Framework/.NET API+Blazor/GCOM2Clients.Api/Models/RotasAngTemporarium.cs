using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RotasAngTemporarium
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public int? IdUtilizador { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? Activo { get; set; }

    public bool Estacao { get; set; }

    public bool Distribuicao { get; set; }

    public int IdEntidade { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdVia { get; set; }

    public int? IdClasse { get; set; }

    public int? PesoMin { get; set; }

    public int? PesoMax { get; set; }

    public int? VolumeMinM3 { get; set; }

    public int? VolumeMaxM3 { get; set; }

    public int? EnviosMin { get; set; }

    public int? EnviosMax { get; set; }

    public int? VolumesMin { get; set; }

    public int? VolumesMax { get; set; }

    public bool TratarVolume { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdEntidadeDelega { get; set; }

    public int? IdZona { get; set; }

    public bool IsSecurityControl { get; set; }

    public int? IdTarifa { get; set; }

    public int? IdModoTransporte { get; set; }
}
