using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CargoScannerRazoesNaoConferirT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
