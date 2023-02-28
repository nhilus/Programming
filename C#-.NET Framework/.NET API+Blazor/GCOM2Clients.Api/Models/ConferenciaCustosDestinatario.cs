using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConferenciaCustosDestinatario
{
    public int Id { get; set; }

    public int IdConferenciaCustosEnvios { get; set; }

    public string? NomeContacto { get; set; }

    public string? Companhia { get; set; }

    public string? EnderecoLinha1 { get; set; }

    public string? EnderecoLinha2 { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? CodigoPostal { get; set; }

    public string? SiglaPais { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }
}
