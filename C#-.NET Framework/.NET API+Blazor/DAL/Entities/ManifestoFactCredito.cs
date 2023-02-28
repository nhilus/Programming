using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoFactCredito
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public bool? AlteraValor { get; set; }

    public DateTime? DtAlteraValor { get; set; }

    public bool? ParaProcessar { get; set; }

    public DateTime? DtParaProcessar { get; set; }

    public short? IdUtilParaProcessar { get; set; }

    public bool Processado { get; set; }

    public DateTime? DtProcessado { get; set; }

    public short? IdUtilProcessado { get; set; }

    public DateTime DtIntrod { get; set; }

    public short? IdUtilIntrod { get; set; }

    public int? IdManifestoItem { get; set; }
}
