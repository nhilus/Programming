using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CustomHtmlField
{
    public int CustomHtmlFieldsId { get; set; }

    public string? CodigoGeral { get; set; }

    public string? IdCodigo { get; set; }

    public string? Descricao { get; set; }

    public string? Valor { get; set; }

    public bool? Activo { get; set; }
}
