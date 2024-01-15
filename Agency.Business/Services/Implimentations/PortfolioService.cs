using Agency.Business.Helpers;
using Agency.Business.Services.Interfaces;
using Agency.Business.ViewModels.PortfolioVM;
using Agency.Core.Entities;
using Agency.DAL.Repository.Implimentations;
using Agency.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.Services.Implimentations
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _repo;

        public PortfolioService(IPortfolioRepository repo)
        {
            _repo = repo;
        }
        public async Task Create(CreatePortfolioVM portfolioVM, string env)
        {
            Portfolio newPortfolio = new Portfolio()
            {
                Title = portfolioVM.Title,
                Description = portfolioVM.Description,
                Category = portfolioVM.Category
            };
            await _repo.Create(newPortfolio);
            await _repo.SaveChanges();
        }

        public async Task Delete(int id)
        {

            await _repo.Delete(id);
            await _repo.SaveChanges();
        }

        public async Task<IQueryable<Portfolio>> GetAllAsync()
        {
            IQueryable<Portfolio> query = await _repo.GetAll();
            return query;
        }

        public async Task<Portfolio> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(UpdatePortfolioVM portfolio, string env)
        {
            Portfolio oldPortfolio = await _repo.GetById(portfolio.Id);
            oldPortfolio.Title = portfolio.Title;
            oldPortfolio.Description = portfolio.Description;
            oldPortfolio.Category = portfolio.Category;
            FileManager.Delete(oldPortfolio.ImgUrl, env, @"\Upload\PortfolioImages\");
            oldPortfolio.ImgUrl = portfolio.File.Upload(env, @"\Upload\PortfolioImages\");
            await _repo.Update(oldPortfolio);
            await _repo.SaveChanges();

        }
    }
}
