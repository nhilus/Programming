using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class InformacaoEnvioGeox
{
    public int? PicExp { get; set; }

    public string? RefCli { get; set; }

    public int? PicDdt { get; set; }

    public DateTime? PicDDdt { get; set; }

    public string? PicRefCli { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool? Enviado { get; set; }
}
