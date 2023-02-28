using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConversasMensagen
{
    public int Id { get; set; }

    public int IdConversa { get; set; }

    public int IdUtilDest { get; set; }

    public DateTime DtIntrod { get; set; }

    public string Util { get; set; } = null!;

    public string Observacoes { get; set; } = null!;

    public bool Prio { get; set; }
}
