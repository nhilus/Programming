using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFuncoesEntidade
{
    public int Id { get; set; }

    public short IdUtil { get; set; }

    public short IdUtilizadorFuncaoEntidade { get; set; }

    public bool IsLeader { get; set; }
}
