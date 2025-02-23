using FluentResults;
using IdentityService.Domain.Models;

namespace IdentityService.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<Result<UserDomainModel>> CreateAsync(string email, string password);
    Task<Result<UserDomainModel>> VerifyUserPasswordAsync(string email, string password);
    Task<Result<UserDomainModel>> FindByEmailAsync(string email);
    Task<Result<IEnumerable<UserDomainModel>>> GetAllAsync();
    Task<Result<UserDomainModel>> FindByIdAsync(string userId);
}
