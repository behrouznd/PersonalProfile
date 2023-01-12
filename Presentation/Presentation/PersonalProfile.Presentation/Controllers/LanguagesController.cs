using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObject;

namespace PersonalProfile.Presentation.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public LanguagesController(IServiceManager serviceManager) => this._service = serviceManager;


        [HttpGet]
        public IActionResult GetLanguages()
        {
            var languages = _service.LanguageService.GetAllLanguages(trackChanges: false);
            return Ok(languages);             
        }

        [HttpGet("{id:guid}", Name = "LanguageById")]
        public IActionResult GetLanguage(Guid id)
        {
            var language = _service.LanguageService.GetLanguage(id, trackChanges: false);
            return Ok(language);
        }
        
        [HttpPost]
        public IActionResult CreateLanguage([FromBody] LanguageForCreationDto language)
        {
            if (language == null)
                return BadRequest("LanguageForCreationDto object is null");

            var createdLanguage= _service.LanguageService.CreateLanguage(language);
            return CreatedAtRoute("LanguageById", new { id = createdLanguage.Id }, createdLanguage);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteLanguage(Guid id)
        {
            _service.LanguageService.DeleteLanguage(id,trackChanges: false);
            return NoContent();
        }
    }
}
