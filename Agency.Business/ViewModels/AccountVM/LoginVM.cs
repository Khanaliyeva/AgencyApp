using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.ViewModels.AccountVM
{
    public class LoginVM
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
