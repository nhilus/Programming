using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncoesT
{
    public short Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdDepartamento { get; set; }

    public short? IdFuncaoSup { get; set; }

    public byte? Nivel { get; set; }

    public bool IsDestBoff { get; set; }

    public bool IsDestCrm { get; set; }
}
