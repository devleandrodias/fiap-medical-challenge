using Fiap.MedicalChallenge.Infrastructure.Dtos.Patient;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadPatientDto>> Get()
        {
            IEnumerable<ReadPatientDto> readDto = _service.Get();

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadPatientDto> GetById([FromRoute] int id)
        {
            ReadPatientDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            Result result = _service.Delete(id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreatePatientDto dto)
        {
            ReadPatientDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdatePatientDto dto, [FromRoute] int id)
        {
            Result result = _service.Update(dto, id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
