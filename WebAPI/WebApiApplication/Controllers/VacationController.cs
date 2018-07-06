using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiApplication.Models;
using WebApiApplication.Services;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class VacationController : ControllerBase
    {
        private readonly IVacationService _vacationService;

        public VacationController(IVacationService vacationService)
        {
            _vacationService = vacationService;
        }

        // GET: api/Vacation
        [HttpGet]
        public IEnumerable<VacationResultModel> Get()
        {
            return new[] { new VacationResultModel(), new VacationResultModel() };
        }

        // GET: api/Vacation/5
        [HttpGet("{id}", Name = "Get")]
        public VacationResultModel Get(int id)
        {
            return new VacationResultModel();
        }

        // POST: api/Vacation
        [HttpPost]
        public void Post([FromBody] VacationInputModel value)
        {
            // Do something useful here
        }

        // PUT: api/Vacation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VacationInputModel value)
        {
            // Do something useful here
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Do something useful here
        }

        [Authorize(Policy = "IsManager")]
        [HttpPut("{id}/approve")]
        public void Approve(int id)
        {
            _vacationService.Approve(id);
        }

        [Authorize(Policy = "IsManager")]
        [HttpPut("{id}/reject")]
        public void Reject(int id)
        {
            _vacationService.Approve(id);
        }
    }
}
