using ExampleRestApi.Communication.Requests;
using ExampleRestApi.Exceptions;
using FluentValidation;

namespace ExampleRestApi.Application.UseCase.User.Register
{
    public class RegisterUserValidation : AbstractValidator<RequestRegisterUserJson>
    {
        public RegisterUserValidation()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesExceptions.NAME_EMPTY);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesExceptions.EMAIL_EMPTY);
            RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesExceptions.EMAIL_INVALID);
            RuleFor(user => user.Password.Length).GreaterThanOrEqualTo(8).WithMessage(ResourceMessagesExceptions.EMAIL_EMPTY);
        } 
    }
}
