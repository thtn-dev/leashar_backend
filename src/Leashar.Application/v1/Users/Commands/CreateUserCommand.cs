
using FluentValidation;
using Leashar.Domain.Common.ValueObjects;
using Leashar.Domain.Shared;
using Leashar.Domain.Users;

namespace Leashar.Application.v1.Users.Commands;

public sealed class CreateUserCommand : ICommand<bool>
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    
    public CreateUserCommand(string userName, string email, string password)
    {
        UserName = userName;
        Email = email;
        Password = password;
    }
}

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty()
            .Matches(UserName.GetUserNameRegex());
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty();
    }
}

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, bool>
{

    public CreateUserCommandHandler()
    {
    }

    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userEntity = new UserEntity(UserName.Create(request.UserName), Email.Create(request.Email), request.Password);
        return true;
    }
}