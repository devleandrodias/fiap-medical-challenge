using Fiap.MedicalChallenge.Infrastructure.Dtos.Order;
using Fiap.MedicalChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Open([FromBody] OpenOrderDto dto)
        {
            _service.Open(dto);

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Close([FromBody] CloseOrderDto dto, [FromRoute] int id)
        {
            _service.Close(dto, id);

            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<ReadOrderDto> GetById([FromRoute] int id)
        {
            ReadOrderDto readDto = _service.GetById(id);

            if (readDto == null) return NotFound();

            return Ok(readDto);
        }

        [HttpGet("DrugStorage/{id}")]
        public ActionResult<IEnumerable<ReadOrderDto>> GetByDrugStorageId([FromRoute] int id)
        {
            IEnumerable<ReadOrderDto> readDto = _service.GetByDrugStorageId(id);

            if (!readDto.Any()) return NotFound();

            return Ok(readDto);
        }
    }
}
