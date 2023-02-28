using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NsManifestoScansByDay
{
    public int Id { get; set; }

    public DateTime DtRef { get; set; }

    public int IdManifesto { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public int? IdPltDest { get; set; }

    public int IdScan { get; set; }

    public DateTime? DtPup { get; set; }

    public string ScanCode { get; set; } = null!;

    public DateTime ScanDate { get; set; }

    public DateTime ScanDateDt { get; set; }

    public TimeSpan ScanDateTm { get; set; }

    public DateTime PostDate { get; set; }

    public DateTime PostDateDt { get; set; }

    public TimeSpan PostDateTm { get; set; }

    public DateTime? DtEntregaDesejada { get; set; }

    public bool InSl { get; set; }

    public int QtdSl { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
