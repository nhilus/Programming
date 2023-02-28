using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuUrlcontroloT
{
    public int Id { get; set; }

    public int IdMenuUrl { get; set; }

    public int Bit { get; set; }

    public string Controlo { get; set; } = null!;

    public string DescricaoControlo { get; set; } = null!;
}
