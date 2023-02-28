﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConversasMensagensLog
{
    public int Id { get; set; }

    public int IdConversa { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtil { get; set; }

    public string Observacoes { get; set; } = null!;
}
