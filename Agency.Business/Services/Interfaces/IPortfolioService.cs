using Agency.Business.ViewModels.PortfolioVM;
using Agency.Core.Entities;
using Agency.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<IQueryable<Portfolio>> GetAllAsync();
        Task<Portfolio> GetById(int id);
        Task Delete(int id);
        Task Update(UpdatePortfolioVM portfolio, string env);
        Task Create(CreatePortfolioVM portfolioVM, string env);
    }
}
