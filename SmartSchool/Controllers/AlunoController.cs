using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() 
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Fulano",
                Sobrenome = "Um",
                Telefone = "996956482"   
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Fulano",
                Sobrenome = "Dois",
                Telefone = "995693433"   
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Fulano",
                Sobrenome = "Três",
                Telefone = "896654826"   
            },

        };
        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var aluno = Alunos.FirstOrDefault(x => x.Id == id);
            if(aluno == null) return BadRequest("Aluno não encontrado.");

            return Ok(aluno);
        }
    }
}