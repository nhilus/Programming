using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteContacto
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string? Titulo { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cargo { get; set; }

    public string? Departamento { get; set; }

    public long? Telefone { get; set; }

    public long? Telefone2 { get; set; }

    public long? Fax { get; set; }

    public string? Email { get; set; }

    public string? Observacoes { get; set; }

    public int IdTipoContacto { get; set; }

    public DateTime? DataCriacao { get; set; }

    public int? IdUtilCriacao { get; set; }

    public DateTime? DataUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? Aduaneira { get; set; }

    public bool? Operacoes { get; set; }

    public bool? Financeira { get; set; }

    public bool? Comercial { get; set; }

    public DateTime? HoraEntrada { get; set; }

    public DateTime? HoraInicioAlmoco { get; set; }

    public DateTime? HoraFimAlmoco { get; set; }

    public DateTime? HoraSaida { get; set; }

    public bool Default { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }

    public string? IdeExternoSf { get; set; }
}
