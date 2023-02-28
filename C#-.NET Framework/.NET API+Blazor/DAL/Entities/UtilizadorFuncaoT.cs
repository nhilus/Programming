using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncaoT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdDepartamento { get; set; }

    public byte? IdFuncaoSup { get; set; }

    public byte Nivel { get; set; }
}
