using Fiap.MedicalChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.MedicalChallenge.Api.Controllers
{
    [ApiController, Route("v1/Drugstore")]
    public class DrugstoreController : ControllerBase
    {
        private readonly IDrugStorageService _service;

        public DrugstoreController(IDrugStorageService service)
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
