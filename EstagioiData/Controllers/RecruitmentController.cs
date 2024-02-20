using EstagioiData.Model;
using EstagioiData.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EstagioiData.Controllers
{
    [ApiController]
    [Route("api/v1/idata")]
    public class RecruitmentController : ControllerBase
    {
        private readonly IRecruitmentRepository _recruitmentRepository;

        public RecruitmentController(IRecruitmentRepository idataRepository)
        {
            _recruitmentRepository = idataRepository ?? throw new ArgumentNullException(nameof(idataRepository));
        }

        [HttpPost]
        public IActionResult Add(RecruitmentViewModel recruitmentview)
        {
            var recruitment = new Recruitment(
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

            _recruitmentRepository.Add(recruitment);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var idatass = _recruitmentRepository.Get();

            return Ok(idatass);
        }
    }
}