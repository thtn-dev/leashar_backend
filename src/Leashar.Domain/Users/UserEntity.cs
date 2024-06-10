using Ardalis.GuardClauses;
using ErrorOr;
using Leashar.Domain.Common.ValueObjects;
using Leashar.Domain.Shared;
using Leashar.Domain.Shared.Entities;

namespace Leashar.Domain.Users;

public class UserEntity : EntityBase<string>, IAggregateRoot
{
    public UserName UserName { get; private set; }
    public Email Email { get;  private set; }
    public string HashedPassword { get; private set; }
    
    public UserEntity(UserName userName, Email email, string hashedPassword)
    {
        Id = Guid.NewGuid().ToString();
        UserName = userName;
        Email = email;
        HashedPassword = hashedPassword;
    }
    
    public void SetUserName(string userName)
    {
        Guard.Against.NullOrWhiteSpace(userName, nameof(userName));
        UserName = UserName.Create(userName);
    }
    
    public void SetEmail(string email)
    {
        Guard.Against.NullOrWhiteSpace(email, nameof(email));
        Email = Email.Create(email);
    }

    public void SetHashedPassword(string hashedPassword)
    {
        Guard.Against.NullOrWhiteSpace(hashedPassword, nameof(hashedPassword));
        HashedPassword = hashedPassword;
    }
    private UserEntity() { }
    //public UserEntity(string userName, string email, string hashedPassword)
    //{
    //    UserName = UserName.Create(userName);
    //    Email = Email.Create(email);
    //    HashedPassword = hashedPassword;
    //}
}