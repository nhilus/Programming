using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncoesEntidade
{
    public int Id { get; set; }

    public short IdUtil { get; set; }

    public short IdUtilizadorFuncaoEntidade { get; set; }

    public bool IsLeader { get; set; }
}
