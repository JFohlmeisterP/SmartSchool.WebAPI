using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProfessorController : ControllerBase
    {
        public ProfessorController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: Petrova, Lichtenstein e Evanoki.");
        }
    }
}