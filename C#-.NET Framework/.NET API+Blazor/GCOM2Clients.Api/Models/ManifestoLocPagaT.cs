using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoLocPagaT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string DescPt { get; set; } = null!;

    public string DescEn { get; set; } = null!;

    public bool Activo { get; set; }

    public bool IsTrans { get; set; }

    public bool IsDir { get; set; }

    public string? CodNumFedEx { get; set; }

    public string? CoGCOM2UsersfaFedEx { get; set; }

    public string? CodigoGidwin { get; set; }
}
