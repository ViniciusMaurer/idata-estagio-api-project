using System;

namespace EstagioiData.ViewModel
{
    public class RecruitmentViewModel // ViewModel que representa os dados da tabela para uso nas camadas de apresentação
    {
        public int Id { get; set; }
        public string? Exportador { get; set; }
        public string? Importador { get; set; }
        public DateTime? DataEmbarque { get; set; }
        public DateTime? PrevisaoDeEmbarque { get; set; }
        public DateTime? DataChegada { get; set; }
        public DateTime? PrevisaoDeChegada { get; set; }
        public string? Di {  get; set; }
        public string? Navio { get; set; }
        public string? Master { get; set; }
        public string? House { get; set; }
        public string? Fatura { get; set; }
        public string? FreteModo { get; set; }
        public string? Container { get; set; }
        public string? CanalParametrizacao { get; set; }
        public string? Origem { get; set; }
        public string? Destino { get; set; }
        public DateTime? LiberadoParaFaturamento { get; set; }
    }
}