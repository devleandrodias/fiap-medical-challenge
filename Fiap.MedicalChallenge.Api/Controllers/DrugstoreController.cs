using Fiap.MedicalChallenge.Infrastructure.Dtos.DrugStorage;
using Fiap.MedicalChallenge.Service.Interfaces;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/DrugStorage")]
    public class DrugStorageController : ControllerBase
    {
        private readonly IDrugStorageService _service;

        public DrugStorageController(IDrugStorageService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadDrugStorageDto>> Get()
        {
            IEnumerable<ReadDrugStorageDto> readDto = _service.Get();

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ReadDrugStorageDto> GetById([FromRoute] int id)
        {
            ReadDrugStorageDto readDto = _service.GetById(id);

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
        public ActionResult Create([FromBody] CreateDrugStorageDto dto)
        {
            ReadDrugStorageDto readDto = _service.Create(dto);

            return CreatedAtAction(nameof(GetById), new { readDto.Id }, readDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateDrugStorageDto dto, [FromRoute] int id)
        {
            Result result = _service.Update(dto, id);

            if (result.IsFailed) return NotFound();

            return NoContent();
        }
    }
}
