using Fiap.MedicalChallenge.Infrastructure.Dtos.Prescription;
using Fiap.MedicalChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Prescription")]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionService _service;

        public PrescriptionController(IPrescriptionService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreatePrescriptionDto dto)
        {
            ReadPrescriptionDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadPrescriptionDto> GetById([FromRoute] int id)
        {
            ReadPrescriptionDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("Doctor/{id}")]
        public ActionResult<IEnumerable<ReadPrescriptionDto>> GetByDoctorId([FromRoute] int id)
        {
            IEnumerable<ReadPrescriptionDto> readDto = _service.GetByDoctorId(id);

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("Patient/{id}")]
        public ActionResult<IEnumerable<ReadPrescriptionDto>> GetByPatientId([FromRoute] int id)
        {
            IEnumerable<ReadPrescriptionDto> readDto = _service.GetByPatientId(id);

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }
    }
}
