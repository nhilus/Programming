﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteCustomerCareT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
