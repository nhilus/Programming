using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class IncidenciasBuytrago
{
    public string? CodIncid { get; set; }

    public string? Descricao { get; set; }

    public int? Nivel { get; set; }

    public string? Scancode { get; set; }

    public bool? Enviar { get; set; }

    public bool? ReceberComoScan { get; set; }

    public bool? ReceberComoComentario { get; set; }

    public string? Er { get; set; }

    public string? ScanEntradaTms { get; set; }

    public int IdTemp { get; set; }
}
