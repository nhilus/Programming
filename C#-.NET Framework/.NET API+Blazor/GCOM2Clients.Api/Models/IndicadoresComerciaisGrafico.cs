using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class IndicadoresComerciaisGrafico
{
    public int Id { get; set; }

    public string Tema { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Funcao { get; set; } = null!;

    public bool? Activo { get; set; }
}
