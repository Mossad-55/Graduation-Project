using AutoMapper;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Service.Contracts;
using Shared.DataTranferObjects;
using Shared.Helpers;
using Shared.Utilities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Service;

public sealed class AuthService : IAuthService
{
    private readonly IServiceManager _service;
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;
    private readonly JWT _jwt;

    public AuthService(IServiceManager service, UserManager<User> userManager, IMapper mapper, IOptions<JWT> options)
    {
        _service = service;
        _userManager = userManager;
        _mapper = mapper;
        _jwt = options.Value;
    }

    public async Task<UserDetailsDto> LoginAdminAsync(LoginDto model, bool trackChanges)
    {
        // Getting the user.
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user is null)
            throw new UserNotFoundException(model.Email);

        // Checking for Email and Password.
        if (!await _userManager.CheckPasswordAsync(user, model.Password))
            throw new WrongEmailOrPasswordException();

        // Check for Admin Role.
        var userRole = await _userManager.GetRolesAsync(user);
        if (userRole[0] != StaticData.UniversityAdminRole &&
            userRole[0] != StaticData.FacultyAdminRole &&
            userRole[0] != StaticData.DepartmentAdminRole)
            throw new AccessDeniedException();

        // Creating a JWT token 
        var jwtSecurityToken = await CreateJwtToken(user);

        // Initialize UserDetailsDto
        var userDetails = new UserDetailsDto();
        userDetails.UserId = user.Id;
        userDetails.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        userDetails.Role = userRole[0];
        userDetails.Email = user.Email;
        userDetails.IsAuthenticated = true;

        Guid userId = new Guid(user.Id);
        if (userRole[0] == StaticData.UniversityAdminRole)
        {
            var uniAdminDto = _service.UniversityAdminService.GetUniveristyAdminById(userId, trackChanges);
            userDetails.UniversityId = uniAdminDto.UniversityId;
        }else if (userRole[0] == StaticData.FacultyAdminRole)
        {
            var facAdminDto = _service.FacultyAdminService.GetFacultyAdminById(userId, trackChanges);
            userDetails.UniversityId = facAdminDto.UniveristyId;
            userDetails.FacultyId = facAdminDto.FacultyId;
        }
        else if (userRole[0] == StaticData.DepartmentAdminRole)
        {
            var depAdminDto = _service.DepartmentAdminService.GetDepartmentAdminById(userId, trackChanges);
            userDetails.UniversityId = depAdminDto.UniveristyId;
            userDetails.FacultyId = depAdminDto.FacultyId;
            userDetails.DepartmentId = depAdminDto.DepartmentId;
        }

        return userDetails;
    }

    public Task<UserDetailsDto> LoginProfessorAsync(LoginDto model)
    {
        throw new NotImplementedException();
    }

    public Task<UserDetailsDto> LoginStudentAsync(LoginDto model)
    {
        throw new NotImplementedException();
    }

    // Private Functions.
    private async Task<JwtSecurityToken> CreateJwtToken(User user)
    {
        // Getting user claims.
        var userClaims = await _userManager.GetClaimsAsync(user);

        // Getting user role.
        var roles = await _userManager.GetRolesAsync(user);
        var roleClaims = new List<Claim>();

        // Adding Claim Roles.
        foreach (var role in roles)
            roleClaims.Add(new Claim("roles", role));

        // Adding Claims.
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("uid", user.Id)
        }
        .Union(userClaims)
        .Union(roleClaims);

        // Creating the Symmetric Security key by our key.
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));

        // Creating Signing credentials with the algorithm HmacSha256.
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        // Making the JWT Token
        var jwtSecurityToken = new JwtSecurityToken(
            issuer: _jwt.Issuer,
            audience: _jwt.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
            signingCredentials: signingCredentials);

        return jwtSecurityToken;
    }

}
