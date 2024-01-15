using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.ViewModels.PortfolioVM
{
    public class CreatePortfolioVM
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public IFormFile? File { get; set; }
    }
}
