using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
