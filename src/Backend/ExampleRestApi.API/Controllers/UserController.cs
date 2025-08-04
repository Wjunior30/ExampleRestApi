using ExampleRestApi.Application.UseCase.User.Register;
using ExampleRestApi.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ExampleRestApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly RegisterUserUseCase _useCase;

        public UserController(RegisterUserUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public IActionResult Register(RequestRegisterUserJson request)
        {
            var result = _useCase.Execute(request);
            return Created(string.Empty, result);
        }
    }
}
