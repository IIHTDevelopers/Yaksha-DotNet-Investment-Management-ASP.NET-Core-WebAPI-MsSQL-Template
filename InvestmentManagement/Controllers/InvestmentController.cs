using InvestmentManagement.BusinessLayer.Interfaces;
using InvestmentManagement.BusinessLayer.ViewModels;
using InvestmentManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestmentManagement.Controllers
{
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        private readonly IInvestmentService _investmentService;
        public InvestmentController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpPost]
        [Route("create-investment")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateInvestment([FromBody] Investment model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-investment")]
        public async Task<IActionResult> UpdateInvestment([FromBody] InvestmentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete-Investment")]
        public async Task<IActionResult> DeleteInvestment(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-Investment-by-id")]
        public async Task<IActionResult> GetInvestmentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-investments")]
        public async Task<IEnumerable<Investment>> GetAllInvestments()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}