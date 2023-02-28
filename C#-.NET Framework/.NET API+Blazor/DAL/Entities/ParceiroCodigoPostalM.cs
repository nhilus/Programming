using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParceiroCodigoPostalM
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEntidade { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public string? Plataforma { get; set; }
}
