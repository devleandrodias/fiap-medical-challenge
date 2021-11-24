using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Doctor;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _service;

        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Doctor>> Get()
        {
            IEnumerable<ReadDoctorDto> readDto = _service.Get();

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> GetById([FromRoute] int id)
        {
            ReadDoctorDto readDto = _service.GetById(id);

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
        public ActionResult Create([FromBody] CreateDoctorDto dto)
        {
            ReadDoctorDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateDoctorDto dto, [FromRoute] int id)
        {
            Result result = _service.Update(dto, id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
