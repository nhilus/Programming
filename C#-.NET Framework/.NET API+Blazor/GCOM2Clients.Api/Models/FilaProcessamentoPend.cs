using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FilaProcessamentoPend
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public bool IsPrio { get; set; }

    public byte IdClasse { get; set; }

    public short IdInstrucao { get; set; }

    public bool IsReadyToExec { get; set; }
}
