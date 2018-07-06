using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FeatureFolderWebApiApplication.Vacation
{
    [Route("api/vacation")]
    [Authorize(Policy = "IsManager")]
    [ApiController]
    public class ApprovalController : ControllerBase
    {
        private readonly IVacationService _vacationService;

        public ApprovalController(IVacationService vacationService)
        {
            _vacationService = vacationService;
        }

        [HttpPut("{id}/approve")]
        public void Approve(int id)
        {
            _vacationService.Approve(id);
        }

        [HttpPut("{id}/reject")]
        public void Reject(int id)
        {
            _vacationService.Reject(id);
        }
    }
}
