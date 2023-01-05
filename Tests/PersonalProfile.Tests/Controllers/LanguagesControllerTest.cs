
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalProfile.Presentation.Controllers;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using Xunit;

namespace PersonalProfile.Tests.Controllers
{
    public class LanguagesControllerTest
    {
        private readonly Mock<IServiceManager> _mockServiceManager;

        private readonly LanguagesController _languagesController;

        public LanguagesControllerTest()
        {
            _mockServiceManager = new Mock<IServiceManager>();
            _languagesController = new  LanguagesController(_mockServiceManager.Object);
        }

        [Fact]
        public void GetLanguages_ActionExecutes_ReturnExactNumberOfLanguage()
        {
            _mockServiceManager.Setup(s => s.LanguageService.GetAllLanguages(false))
                .Returns(new List<LanguageDto>() { new LanguageDto(new Guid() , "" , "" , ""), 
                    new LanguageDto(new Guid() , "" , "" , "") });

            var result = _languagesController.GetLanguages();

            var iactionResult = Assert.IsType<OkObjectResult>(result);

            var languages = Assert.IsType<List<LanguageDto>>(iactionResult.Value);

            Assert.Equal(2, languages.Count);
        }

        [Fact]
        public void GetLanguage_ActionExecutes_ReturnExactLanguage()
        {
            LanguageDto languageDto = new LanguageDto(new Guid(), "", "", "");
            _mockServiceManager.Setup(s => s.LanguageService.GetLanguage(languageDto.Id, false))
                .Returns(languageDto);

            var result = _languagesController.GetLanguage(languageDto.Id);

            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var language = Assert.IsType<LanguageDto>(okObjectResult.Value);
            Assert.True(languageDto.Equals(language));
        }

        [Fact]
        public void CreateLanguage_NullParameter_ThrowBadRequestException()
        {
            Assert.IsType<BadRequestObjectResult>(_languagesController.CreateLanguage(null));
        }

        [Fact]
        public void CreateLanguage_ValidLanguageParameter_CreateLanguage()
        {
            LanguageDto? lng = null;

            _mockServiceManager.Setup(s => s.LanguageService.CreateLanguage(It.IsAny<LanguageForCreationDto>()))               
                .Returns<LanguageForCreationDto>(x => lng = new LanguageDto(new Guid(), x.Name , x.Abbreviation , x.PathFlag));

            LanguageForCreationDto languageForCreationDto = new LanguageForCreationDto("abc", "ab", "a");

            _languagesController.CreateLanguage(languageForCreationDto);

            _mockServiceManager.Verify(x=>x.LanguageService.CreateLanguage(It.IsNotNull<LanguageForCreationDto>()), Times.Once());

            Assert.Equal(lng.Name, languageForCreationDto.Name);
            Assert.Equal(lng.Abbreviation, languageForCreationDto.Abbreviation);
            Assert.Equal(lng.PathFlag, languageForCreationDto.PathFlag);

        }
    }
}
