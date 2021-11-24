using Fiap.MedicalChallenge.Service.Interfaces;
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
        public void Get()
        {

        }

        [HttpGet("{id}")]
        public void GetById([FromRoute] int id)
        {

        }
    }
}
