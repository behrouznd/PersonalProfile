using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObject;

namespace PersonalProfile.Presentation.Controllers
{
    [Route("api/languages/{languageId}/personalinfos")]
    [ApiController]
    public class PersonalInfosController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PersonalInfosController(IServiceManager serviceManager)=>  this._service = serviceManager;
        

        [HttpGet(Name = "GetPersonalInfoForLanguage")]
        public IActionResult GetPersonalInfoForLanguage(Guid languageId)
        {
            var personalInfos = _service.PersonalInfoService.GetPersonalInfo(languageId, trackChanges: false);
            return Ok(personalInfos);
        }


        [HttpPost]
        public IActionResult CreatePersonalInfoForLanguage(Guid languageId,[FromBody] PersonalInfoForCreationDto personalInfo)
        {
            if (personalInfo == null)
                return BadRequest("PersonalInfoObject is null");

            var personalInfoToReturn = _service.PersonalInfoService.CreatePersonalInfo(languageId, personalInfo, trackChanges: false);

            return CreatedAtRoute("GetPersonalInfoForLanguage", new { languageId }, personalInfoToReturn);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeletePersonalInfoForLanguage(Guid languageId,Guid id)
        {
            _service.PersonalInfoService.DeletePersonalInfo(languageId,personalId: id , trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdatePersonalInfoForLanguage(Guid languageId,Guid id,[FromBody] PersonalInfoForUpdateDto personalInfo)
        {
            if (personalInfo == null)
                return BadRequest("PersonalInfo object is null");
            _service.PersonalInfoService.UpdatePersonalInfoForLanguage(languageId,id, personalInfo, false,true);
            return NoContent();
        }
    }
}
