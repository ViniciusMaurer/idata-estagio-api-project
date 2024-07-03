using EstagioiData.Model;
using EstagioiData.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EstagioiData.Controllers
{
    // Controlador responsável por manipular as requisições relacionadas a tabela
    [ApiController]
    [Route("api/v1/idata")]
    public class RecruitmentController : ControllerBase
    {
        private readonly IRecruitmentRepository _recruitmentRepository; // Repositório para acesso ao banco de dados

        // Construtor da classe que recebe o repositório de recrutamentos por injeção de dependência
        public RecruitmentController(IRecruitmentRepository idataRepository)
        {
            _recruitmentRepository = idataRepository ?? throw new ArgumentNullException(nameof(idataRepository));
        }

        [HttpPost] // Método para lidar com requisições POST para adicionar uma nova informação
        public IActionResult Add(RecruitmentViewModel recruitmentview)
        {
            var recruitment = new Recruitment( // Cria um novo objeto Recruitment com base nos dados recebidos da requisição
                recruitmentview.Id,
                recruitmentview.Exportador,
                recruitmentview.Importador,
                recruitmentview.DataEmbarque ?? DateTime.MinValue,
                recruitmentview.PrevisaoDeEmbarque ?? DateTime.MinValue,
                recruitmentview.DataChegada ?? DateTime.MinValue,
                recruitmentview.PrevisaoDeChegada ?? DateTime.MinValue,
                recruitmentview.Di,
                recruitmentview.Navio,
                recruitmentview.Master,
                recruitmentview.House,
                recruitmentview.Fatura,
                recruitmentview.FreteModo,
                recruitmentview.Container,
                recruitmentview.CanalParametrizacao,
                recruitmentview.Origem,
                recruitmentview.Destino,
                recruitmentview.LiberadoParaFaturamento ?? DateTime.MinValue 
            );

            _recruitmentRepository.Add(recruitment); // Adiciona ao banco de dados através do repositório

            return Ok(); // Retorna uma resposta HTTP 200 (OK)
        }

        [HttpGet] // Método para lidar com requisições GET para obter todas as informações
        public IActionResult Get()
        {
            var idatass = _recruitmentRepository.Get(); // Obtém todos os dados do banco de dados através do repositório

            return Ok(idatass); // Retorna uma resposta HTTP 200 (OK) com a lista de recrutamentos
        }
    }
}