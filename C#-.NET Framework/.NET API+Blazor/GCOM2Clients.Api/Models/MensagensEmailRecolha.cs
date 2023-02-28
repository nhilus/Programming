using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MensagensEmailRecolha
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Texto { get; set; }

    public string? Campo { get; set; }

    public bool? IsMandatoryMessage { get; set; }
}
