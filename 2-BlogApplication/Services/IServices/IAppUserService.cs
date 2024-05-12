using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.DTOs;

namespace _2_BlogApplication.Services.IServices
{
    public interface IAppUserService
    {
        Task<AppUserDTO> GetUserByIdAsync(string userId);
        Task<IEnumerable<AppUserDTO>> GetUserAsync();
        int CreateAsync(AppUserDTO appUserDTO);
        int UpdateAsync(AppUserDTO appUserDTO);
        Task<int> DeleteAsync(string userId);
    }
}