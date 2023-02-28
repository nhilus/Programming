using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosDetTBk20170317
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdAreaNeg { get; set; }

    public bool IsManual { get; set; }

    public bool IsAuto { get; set; }

    public bool IsAdicional { get; set; }

    public bool IsObrigatorio { get; set; }

    public bool IsComissionavel { get; set; }

    public int? IdTipoIva { get; set; }

    public string? CodIva { get; set; }

    public bool IncLinZero { get; set; }

    public bool TemTarifa { get; set; }

    public bool AssociaCliente { get; set; }

    public bool MostraCliente { get; set; }

    public bool ImportaCliente { get; set; }

    public bool AlteraCliente { get; set; }

    public bool MostraDesconto { get; set; }

    public bool AlteraDesconto { get; set; }

    public int? CgTpProdutoVang { get; set; }

    public int IdEntidade { get; set; }

    public bool Activo { get; set; }

    public bool? PodeReqValidacao { get; set; }

    public bool IsValidForSos { get; set; }

    public string? DescSos { get; set; }

    public int? IdServicoDetBase { get; set; }

    public bool IsProducaoAgente { get; set; }

    public bool? IsValidRecolha { get; set; }

    public bool ObrigatoriaSeValor { get; set; }

    public string? DescricaoWeb { get; set; }

    public bool? MostraWeb { get; set; }
}
