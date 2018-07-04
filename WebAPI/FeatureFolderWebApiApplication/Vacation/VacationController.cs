using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FeatureFolderWebApiApplication.Vacation
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class VacationController : ControllerBase
    {
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
    }
}
