using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.Models;
using _2_BlogApplication.DTOs;
using _2_BlogApplication.Services.IServices;
using _2_BlogApplication.Utilities.IUnitOfWorks;
using AutoMapper;

namespace _2_BlogApplication.Services
{
    public class AppUserService: IAppUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AppUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public int CreateAsync(AppUserDTO appUserDTO)
        {
            var appuser=mapper.Map<AppUser>(appUserDTO);
            return unitOfWork.AppUserRepo.Add(appuser);
        }

        public async Task<int> DeleteAsync(string userId)
        {
            var user=await unitOfWork.AppUserRepo.GetByIdAsync(userId);
            return unitOfWork.AppUserRepo.Delete(user);
        }
        int IAppUserService.UpdateAsync(AppUserDTO appUserDTO)
        {
            var user=mapper.Map<AppUser>(appUserDTO);
            return unitOfWork.AppUserRepo.Update(user);
        }

        public async Task<IEnumerable<AppUserDTO>> GetUserAsync()
        {
           var users=await unitOfWork.AppUserRepo.GetAllAsync();
           return mapper.Map<IEnumerable<AppUserDTO>>(users);
        }

        public async Task<AppUserDTO> GetUserByIdAsync(string userId)
        {
           var user=await unitOfWork.AppUserRepo.GetByIdAsync(userId);
           return mapper.Map<AppUserDTO>(user);
        }
    }
}