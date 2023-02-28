using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EnviosProvedorIncidencia
{
    public int Id { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public string? Solicitante { get; set; }

    public string? Pass { get; set; }

    public string? CanalEntrada { get; set; }

    public string? NumEnvio { get; set; }

    public string? Referencia { get; set; }

    public string? FechaEnvio { get; set; }

    public string? Cliente { get; set; }

    public string? NomeDest { get; set; }

    public string? DomDest { get; set; }

    public string? PobDest { get; set; }

    public string? CodPosDest { get; set; }

    public string? ContactoDest { get; set; }

    public string? TelefDest { get; set; }

    public string? CodigoSolucion { get; set; }

    public string? InstruccionesEntrega { get; set; }

    public string? FecharConcertada { get; set; }

    public string? HorarioConcertado1 { get; set; }

    public string? HorarioConcertado2 { get; set; }

    public string? OfficinaCorreos { get; set; }

    public bool? Processado { get; set; }

    public DateTime? DtProcessado { get; set; }

    public string? Msg { get; set; }
}
