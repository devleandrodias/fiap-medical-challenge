using Fiap.MedicalChallenge.Service.Interfaces;
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
        public void Get()
        {

        }

        [HttpGet("{id}")]
        public void GetById([FromRoute] int id)
        {

        }
    }
}
