﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class BackofficeParceiroDestinatario
{
    public int Id { get; set; }

    public int IdFornecedor { get; set; }

    public int? IdUtil { get; set; }

    public int? IdGrupoUtil { get; set; }

    public int? IdFuncaoEntidade { get; set; }
}
