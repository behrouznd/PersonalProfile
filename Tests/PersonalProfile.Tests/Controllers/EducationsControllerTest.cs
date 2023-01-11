using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalProfile.Presentation.Controllers;
using Service.Contracts;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PersonalProfile.Tests.Controllers
{
    public class EducationsControllerTest
    {
        private readonly Mock<IServiceManager> _MockService;
        private readonly EducationsController _EducationsController;
        public EducationsControllerTest()
        {
            _MockService = new Mock<IServiceManager>();
            _EducationsController = new EducationsController(_MockService.Object);
        }

        [Fact]
        public void GetEducationCollection_ActionExecutes_ReturnExactNumberOfEducations()
        {
            List<Guid> guids = new List<Guid> { new Guid("1388CB6A-E02B-4C21-B82A-C3D608DF1D2C"), 
                new Guid("DC620CE4-F967-4DBC-B990-7BE99AB67F9D") };

            _MockService.Setup(s => s.EducationService.GetByIds(guids, false))
                .Returns(new List<EducationDto>(){
                new EducationDto(guids[0],"","",1,DateTime.Now,DateTime.Now,"") ,
                new EducationDto(guids[1],"","",1,DateTime.Now,DateTime.Now,"")});

            var result = _EducationsController.GetEducationCollection(guids);

            var iActionResult = Assert.IsType<OkObjectResult>(result);

            var educationList = Assert.IsType<List<EducationDto>>(iActionResult.Value);

            Assert.Equal(2, educationList.Count);
            Assert.Equal(guids[0],educationList[0].Id);
            Assert.Equal(guids[1],educationList[1].Id);
        }

        [Fact]
        public void DeleteEducationForPersonalInfo_ActionExecutes_ReturnNoContentResult()
        {
            _MockService.Setup(s=>s.EducationService.DeleteEducationForPersonalInfo(It.IsAny<Guid>(),It.IsAny<Guid>(),false)).Verifiable();                 
            Assert.IsType<NoContentResult>(_EducationsController.DeleteEducationForPersonalInfo(It.IsAny<Guid>(),It.IsAny<Guid>()));
        }
    }
}
