using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuUrlutilizadore
{
    public int Id { get; set; }

    public int IdUtilizador { get; set; }

    public int IdMenuUrl { get; set; }

    public bool TodosUtilizadores { get; set; }

    public bool? TodosClientes { get; set; }

    public bool? TodasPlataformas { get; set; }

    public byte Permissao { get; set; }

    public bool? Visivel { get; set; }

    public bool Default { get; set; }

    public byte PVisualizar { get; set; }

    public byte PEditar { get; set; }

    public bool? Activo { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? TodasEntidades { get; set; }
}
