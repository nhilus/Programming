using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteCustomerCareLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int IdCustomerCare { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? ObjEnvios { get; set; }

    public int? IdUtilAtrib { get; set; }

    public DateTime? DtAtrib { get; set; }

    public int? IdCliMorada { get; set; }
}
