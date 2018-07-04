using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FeatureFolderWebApiApplication.Employee
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeResultModel>> Get()
        {
            return new[] { new EmployeeResultModel(), new EmployeeResultModel() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<EmployeeResultModel> Get(int id)
        {
            return new EmployeeResultModel();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] EmployeeInputModel value)
        {
            // Do something useful here
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeInputModel value)
        {
            // Do something useful here
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Do something useful here
        }
    }
}
