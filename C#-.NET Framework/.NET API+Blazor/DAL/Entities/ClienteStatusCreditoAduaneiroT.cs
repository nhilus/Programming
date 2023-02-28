using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteStatusCreditoAduaneiroT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public short? DiasCredito { get; set; }

    public int? CodigoVanguarda { get; set; }

    public bool? Activo { get; set; }
}
