using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoEntidade
{
    public short Id { get; set; }

    public byte IdUtilizadorFuncao { get; set; }

    public byte IdEntidade { get; set; }

    public byte IdDepartamento { get; set; }

    public short? IdFuncaoSup { get; set; }

    public byte Nivel { get; set; }
}
