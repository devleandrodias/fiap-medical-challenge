using Fiap.MedicalChallenge.Domain.Models;
using Fiap.MedicalChallenge.Infrastructure.Dtos.Drug;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Drug")]
    public class DrugController : ControllerBase
    {
        private readonly IDrugService _service;

        public DrugController(IDrugService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadDrugDto>> Get()
        {
            IEnumerable<ReadDrugDto> readDto = _service.Get();

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadDrugDto> GetById([FromRoute] int id)
        {
            ReadDrugDto readDto = _service.GetById(id);

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
        public ActionResult Create([FromBody] CreateDrugDto dto)
        {
            ReadDrugDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateDrugDto dto, [FromRoute] int id)
        {
            Result result = _service.Update(dto, id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
