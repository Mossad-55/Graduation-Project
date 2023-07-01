using Shared.DataTranferObjects;

namespace Service.Contracts;

public interface IAuthService
{
    Task<UserDetailsDto> LoginAdminAsync(LoginDto model, bool trackChanges);
    Task<UserDetailsDto> LoginProfessorAsync(LoginDto model, bool trackChanges);
    Task<UserDetailsDto> LoginStudentAsync(LoginDto model, bool trackChanges);
}
