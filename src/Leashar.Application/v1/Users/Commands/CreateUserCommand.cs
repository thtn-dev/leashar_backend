
using ErrorOr;
using FluentValidation;
using Leashar.Application.Common.Repositories;
using Leashar.Domain.Common.ValueObjects;
using Leashar.Domain.Shared;
using Leashar.Domain.Users;

namespace Leashar.Application.v1.Users.Commands;

public sealed class CreateUserCommand : ICommand<ErrorOr<bool>>
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

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, ErrorOr<bool>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<bool>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userEntity = new UserEntity(UserName.Create(request.UserName), Email.Create(request.Email), request.Password);

        var existingUser = await _userRepository.FirstOrDefaultAsync(x => x.UserName.Value == request.UserName || x.Email.Value == request.Email, cancellationToken);

        if (existingUser != null)
        {
            return ErrorOr.Error.Conflict("User already exists");
        }

        _userRepository.AddAsync(userEntity);
        var rs = await _unitOfWork.SaveChangesAsync(cancellationToken);
        return rs > 0 ? true : ErrorOr.Error.Failure("Failed to create user");
    }
}