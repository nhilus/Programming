using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaTipoValorT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? IsBaseCalculo { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public bool? VisivelTarFornecedor { get; set; }
}
