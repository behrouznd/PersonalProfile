using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalProfile.Presentation.Controllers;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using Xunit;

namespace PersonalProfile.Tests.Controllers
{
    public class PersonalInfosControllerTest
    {
        private readonly Mock<IServiceManager> _mockService;
        private readonly PersonalInfosController _personalInfosController;
        public PersonalInfosControllerTest()
        {
            _mockService = new Mock<IServiceManager>();
            _personalInfosController = new PersonalInfosController(_mockService.Object);
        }

        [Fact]
        public void GetPersonalInfoForLanguage_ExecuteWithLanguageId_ReturnExactPersonalInfo()
        {
            Guid personalInfoId = Guid.NewGuid();

            _mockService.Setup(s => s.PersonalInfoService.GetPersonalInfo(It.IsAny<Guid>(), false))
                .Returns(new PersonalInfoDto() { Id = personalInfoId});

            var result = _personalInfosController.GetPersonalInfoForLanguage(new Guid());

            var iactionResult = Assert.IsType<OkObjectResult>(result);

            var personalInfo = Assert.IsType<PersonalInfoDto>(iactionResult.Value);

            Assert.Equal(personalInfoId, personalInfo.Id);
        }

        [Fact]
        public void CreatePersonalInfoForLanguage_NullParameter_ThrowBadRequestException()
        {
            Assert.IsType<BadRequestObjectResult>(_personalInfosController.CreatePersonalInfoForLanguage(new Guid(),null));
        }

        [Fact]
        public void CreatePersonalInfoForLanguage_ValidParameters_CreatePersonalInfo()
        {
            PersonalInfoDto? person = null;

            _mockService.Setup(s => s.PersonalInfoService.CreatePersonalInfo(
                new Guid(),
                It.IsAny<PersonalInfoForCreationDto>(),
                false))
                .Callback<Guid , PersonalInfoForCreationDto , bool>((guid , PersonalInfocreateDto , track) =>
                 {
                     Assert.NotNull(PersonalInfocreateDto);
                     person = new PersonalInfoDto()
                     {
                         Name = PersonalInfocreateDto.Name,
                         Family = PersonalInfocreateDto.Family,
                         Title = PersonalInfocreateDto.Title,
                         Address = PersonalInfocreateDto.Address,
                         Birthday = PersonalInfocreateDto.Birthday,
                         Email = PersonalInfocreateDto.Email,
                         Phone = PersonalInfocreateDto.Phone,
                         Mobile = PersonalInfocreateDto.Mobile,
                         Nationality = PersonalInfocreateDto.Nationality,
                         MaritalStatus = PersonalInfocreateDto.MaritalStatus,
                         PicProfile = PersonalInfocreateDto.PicProfile,
                         Residence = PersonalInfocreateDto.Residence,
                         Introduction = PersonalInfocreateDto.Introduction
                     };
                 });

            PersonalInfoForCreationDto personalInfoForCreation =
                new PersonalInfoForCreationDto("Name", "Family", "Title", "", DateTime.Now, 1, "", "", "", "", "", "", "", null);

            _personalInfosController.CreatePersonalInfoForLanguage(new Guid(), personalInfoForCreation);

            _mockService.Verify(x=> x.PersonalInfoService.CreatePersonalInfo(new Guid(),It.IsAny<PersonalInfoForCreationDto>(),false), Times.Once()); 
            Assert.Equal(person.Name, personalInfoForCreation.Name);
            Assert.Equal(person.Title, personalInfoForCreation.Title);
            Assert.Equal(person.Family, personalInfoForCreation.Family);

        }
    }
}
