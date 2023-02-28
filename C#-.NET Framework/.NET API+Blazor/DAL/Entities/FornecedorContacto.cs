using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FornecedorContacto
{
    public int Id { get; set; }

    public int? IdFornecedor { get; set; }

    public int? IdTipoFornecedorContacto { get; set; }

    public string? NomeContacto { get; set; }

    public string? Contacto { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
