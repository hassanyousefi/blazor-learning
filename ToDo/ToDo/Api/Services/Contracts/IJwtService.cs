using ToDo.Api.Models.Account;
using ToDo.Shared.Dtos.Account;

namespace ToDo.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
