﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoDetalhe
{
    public int Id { get; set; }

    public int IdReclamacao { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public int? IdEstado { get; set; }

    public string? Observacoes { get; set; }

    public int? IdUtilDestino { get; set; }

    public int? IdAlerta { get; set; }
}
