using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FornecedorTarifaDetalhe
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public int IdTipoProduto { get; set; }

    public string Zona { get; set; } = null!;

    public decimal Peso { get; set; }

    public decimal PesoSeguinte { get; set; }

    public decimal Valor { get; set; }

    public bool Incrementa { get; set; }
}
