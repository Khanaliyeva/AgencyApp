using Agency.Business.ViewModels.AccountVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Interfaces
{
    public interface IAccountService
    {
        Task Register(RegisterVM register);
        Task Login(LoginVM login);
        Task Logout();
    }
}
