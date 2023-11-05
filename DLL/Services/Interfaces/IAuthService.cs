using DAL.Model;
using DLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Services.Interfaces
{
    public interface IAuthService
    {
        string GenerateTokenString(ApplicationUser user);
        Task<ApplicationUser> Login(LoginRequestDto user);
        Task<bool> RegisterUser(UserCreationDto user);

    }
}
