using DesafioPraticoRocket_2.Communication.Requests;
using DesafioPraticoRocket_2.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPraticoRocket_2.Controllers;

[Route("api/[controller]")]
[ApiController]

public class BookstoreController : ControllerBase
{
    [HttpPost]
    [Route("Registrar")]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = request.Id,
            Title = request.Title,
            CreatedAt = DateTime.UtcNow,
        };

        return Created(string.Empty, response);
    }


    [HttpGet]
    [Route("Consultar")]
    public IActionResult GetAll()
    {
        return Ok("Livros Consultado");
    }


    [HttpPut]
    [Route("Editar")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookJson request)
    {
        
        if (request.Id == 0)
        {
            return BadRequest("Informe o ID do livro");
        }
        else
        {
            return NoContent();
        }
    }


    [HttpDelete]
    [Route("Excluir")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromBody] RequestDeleteBookJson request)
    {
        var response = new ResponseDeleteBookJson
        {
            Id = request.Id,
        };

        if (request.Id <= 0)
        {
            return BadRequest("Informe o ID do livro");
        }
        else
        {
            return Ok(response);
        }
    }
}
