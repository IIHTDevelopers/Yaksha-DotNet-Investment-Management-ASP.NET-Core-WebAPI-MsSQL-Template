using InvestmentManagement.BusinessLayer.ViewModels;
using InvestmentManagement.DataLayer;
using InvestmentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentManagement.BusinessLayer.Services.Repository
{
    public class InvestmentRepository : IInvestmentRepository
    {
        private readonly InvestmentDbContext _dbContext;
        public InvestmentRepository(InvestmentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Investment> CreateInvestment(Investment investment)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteInvestmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Investment> GetAllInvestments()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Investment> GetInvestmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public async Task<Investment> UpdateInvestment(InvestmentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}