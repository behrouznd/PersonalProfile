using Microsoft.AspNetCore.Mvc;
using PersonalProfile.Presentation.ModelBinders;
using Service.Contracts;

namespace PersonalProfile.Presentation.Controllers
{
    [Route("api/personalinfos/{personalinfoid}/educations")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public EducationsController(IServiceManager serviceManager)
        {
            this._service = serviceManager;
        }


        [HttpGet("collection/({ids})", Name = "EducationCollection")]
        public IActionResult GetEducationCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var educations = _service.EducationService.GetByIds(ids,false);
            return Ok(educations);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteEducationForPersonalInfo(Guid personalinfoid, Guid id)
        {
            _service.EducationService.DeleteEducationForPersonalInfo(personalinfoid,id,trackChanges:false);
            return NoContent();
        }
    }
}
