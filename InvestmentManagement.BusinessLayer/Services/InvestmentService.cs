using InvestmentManagement.BusinessLayer.Interfaces;
using InvestmentManagement.BusinessLayer.Services.Repository;
using InvestmentManagement.BusinessLayer.ViewModels;
using InvestmentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentManagement.BusinessLayer.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
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