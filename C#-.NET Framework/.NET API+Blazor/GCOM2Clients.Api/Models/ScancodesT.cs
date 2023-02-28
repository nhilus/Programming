using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ScancodesT
{
    public string Scancode { get; set; } = null!;

    public int IdEntidade { get; set; }

    public string? Descricao { get; set; }

    public string? DescWeb { get; set; }

    public bool Poddex { get; set; }

    public bool Finaliza { get; set; }

    public bool DexAceitavel { get; set; }

    public bool DexInaceitavel { get; set; }

    public bool SaidaDistribuicao { get; set; }

    public int DiasDistribuicao { get; set; }

    public bool ParaCobrancas { get; set; }

    public bool? Activo { get; set; }

    public bool Tratamento { get; set; }

    public bool TratamentoInterno { get; set; }

    public bool TratamentoCliente { get; set; }

    public int? IdTrataDept { get; set; }

    public int? IdTrataGrupo { get; set; }

    public int? TrataNumRepeticoes { get; set; }

    public bool Pda { get; set; }

    public bool ParaFacturar { get; set; }

    /// <summary>
    /// Bit utilizado para o relatorio de 71 e distribuição para nao ter que martelar scans
    /// </summary>
    public bool? Security { get; set; }

    public string? SmallImg { get; set; }

    public bool IniciaEntrega { get; set; }

    public int? OrdemCtrlRoom { get; set; }

    public string? ImgCtrlRoom { get; set; }

    public string? DescTipoScan { get; set; }

    public bool Estacao { get; set; }

    public bool Distribuicao { get; set; }

    public int? IdIncidenciaTipo { get; set; }

    public bool GestaoAdministr { get; set; }

    public bool FinalizaGestaoAdministr { get; set; }

    public bool? EnvPortal { get; set; }

    public bool Gera2TentativaEntrega { get; set; }

    public bool ContaTempoTransito { get; set; }

    public bool? Producao { get; set; }

    public int? IdNotificacaoTipo { get; set; }

    public string? Definicao { get; set; }

    public string? ScanTypeCode { get; set; }

    public string? ScanType { get; set; }

    public bool? IsValidNivelServico { get; set; }

    public string? Categoria { get; set; }

    public bool ParaFacturarCliente { get; set; }

    public bool? ParaFacturarFornecedor { get; set; }

    public bool IsScanFisico { get; set; }

    public bool? AplicaMaster { get; set; }

    public bool? IsScanControlo { get; set; }
}
