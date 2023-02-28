using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosModosPagamentoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int NumDias { get; set; }

    public int IdEntidade { get; set; }

    public int? CodigoVanguarda { get; set; }

    public string? CodigoSap { get; set; }

    public bool Activo { get; set; }
}
