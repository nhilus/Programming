using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteConcorrenteMotivoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public byte IdEntidade { get; set; }
}
