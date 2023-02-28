using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConversasUtil
{
    public int Id { get; set; }

    public int IdConversa { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtIntrod { get; set; }

    public DateTime? DtFim { get; set; }
}
