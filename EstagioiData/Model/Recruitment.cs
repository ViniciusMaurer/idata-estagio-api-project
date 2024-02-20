using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstagioiData.Model
{
    [Table("recruitment")] //identifica o nome correto da tabela
    public class Recruitment
    {
        [Key]
        public int Id { get; set; }
        public string? Exportador { get; set; }
        public string? Importador { get; set; }
        public DateTime? DataEmbarque { get; set; }
        public DateTime? PrevisaoDeEmbarque { get; set; }
        public DateTime? DataChegada { get; set; }
        public DateTime? PrevisaoDeChegada { get; set; }
        public string? DI {  get; set; }
        public string? Navio { get; set; }
        public string? Master {  get; set; }
        public string? House { get; set; }
        public string? Fatura { get; set; }
        public string? FreteModo { get; set; }
        public string? Container { get; set; }
        public string? CanalParametrizacao { get; set; }
        public string? Origem { get; set; }
        public string? Destino { get; set; }
        public DateTime? LiberadoParaFaturamento { get; set; }

        public Recruitment(int id, 
                           string? exportador, 
                           string? importador, 
                           DateTime? dataEmbarque, 
                           DateTime? previsaoDeEmbarque, 
                           DateTime? dataChegada, 
                           DateTime? previsaoDeChegada, 
                           string? dI,
                           string? navio,
                           string? master,
                           string? house,
                           string? fatura,
                           string? freteModo,
                           string? container,
                           string? canalParametrizacao,
                           string? origem,
                           string? destino,
                           DateTime? liberadoParaFaturamento
                           )
        {
            Id = id;
            Exportador = exportador;
            Importador = importador;
            DataEmbarque = dataEmbarque;
            PrevisaoDeEmbarque = previsaoDeEmbarque;
            DataChegada = dataChegada;
            PrevisaoDeChegada = previsaoDeChegada;
            DI = dI;
            Navio = navio;
            Master = master;
            House = house;
            Fatura = fatura;
            FreteModo = freteModo;
            Container = container;
            CanalParametrizacao = canalParametrizacao;
            Origem = origem;
            Destino = destino;
            LiberadoParaFaturamento = liberadoParaFaturamento;
        }
    }
}