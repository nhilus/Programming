using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesDuplicadosAlteracoesLog
{
    public int Id { get; set; }

    public int IdRegisto { get; set; }

    public string TabelaRegisto { get; set; } = null!;

    public int IdClienteOriginal { get; set; }

    public int IdUtil { get; set; }

    public DateTime Data { get; set; }
}
