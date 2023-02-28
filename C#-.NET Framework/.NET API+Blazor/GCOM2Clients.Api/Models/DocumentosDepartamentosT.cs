using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosDepartamentosT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool Importacao { get; set; }

    public bool Exportacao { get; set; }

    public bool Material { get; set; }

    public bool Automatica { get; set; }

    public bool Manual { get; set; }

    public bool TemPlataforma { get; set; }

    public int? IdPlataforma { get; set; }

    public string CodigoFact { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool ValidoBp { get; set; }

    public int? IdRegime { get; set; }

    public bool CredAdu { get; set; }
}
