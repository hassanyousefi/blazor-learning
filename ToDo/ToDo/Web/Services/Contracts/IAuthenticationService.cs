using ToDo.Shared.Dtos.Account;

namespace ToDo.App.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
