using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoAssinaturaDetalhe
{
    public int Id { get; set; }

    public int IdAssinatura { get; set; }

    public short? Linha { get; set; }

    public short? PontoX { get; set; }

    public short? PontoY { get; set; }
}
