using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FilaProcessamentoLog
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public bool IsPrio { get; set; }

    public byte IdClasse { get; set; }

    public short IdInstrucao { get; set; }

    public DateTime DtInicioExec { get; set; }

    public DateTime DtFimExec { get; set; }
}
