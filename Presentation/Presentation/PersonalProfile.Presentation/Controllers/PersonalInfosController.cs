using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace PersonalProfile.Presentation.Controllers
{
    [Route("api/languages/{languageId}/personalinfos")]
    [ApiController]
    public class PersonalInfosController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PersonalInfosController(IServiceManager serviceManager)=>  this._service = serviceManager;
        

        [HttpGet]
        public IActionResult GetPersonalInfoForLanguage(Guid languageId)
        {
            var personalInfos = _service.PersonalInfoService.GetPersonalInfo(languageId , trackChanges: false);
            return Ok(personalInfos);
        }
    }
}
