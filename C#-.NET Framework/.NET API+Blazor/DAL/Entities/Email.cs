using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Email
{
    public int Id { get; set; }

    public string Sender { get; set; } = null!;

    public string Recipient { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime DtEnviar { get; set; }

    public DateTime? DtEnviado { get; set; }

    public DateTime? DtFalhaEnv { get; set; }

    public int? RetryDelay { get; set; }

    public bool Concluido { get; set; }
}
