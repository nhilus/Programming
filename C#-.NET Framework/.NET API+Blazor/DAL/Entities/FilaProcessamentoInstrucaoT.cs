﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FilaProcessamentoInstrucaoT
{
    public short Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdClasse { get; set; }

    public bool? Activo { get; set; }
}