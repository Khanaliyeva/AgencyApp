using Agency.Business.Services.Interfaces;
using Agency.Business.ViewModels.AccountVM;
using Agency.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Implimentations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;


        public AccountService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

 

        public Task Login(LoginVM login)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public async Task Register(RegisterVM registerVM)
        {
            AppUser user = new AppUser()
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                Surname = registerVM.Surname,
                UserName = registerVM.Username
            };

            var result = await _userManager.CreateAsync(user, registerVM.Password);

            if (result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    return;
                }
            }
        }
    }
}
