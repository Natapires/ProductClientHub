using Microsoft.AspNetCore.Mvc;
using ProductClientHub.API.UseCases.Clients.GetAll;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseShortClientJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestClientJson request)
        {
            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllClientsJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllClientsUseCase();

            var response = useCase.Execute();

            if (!response.Clients.Any())
                return NoContent();
            
            return Ok(response);
        }
        
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
