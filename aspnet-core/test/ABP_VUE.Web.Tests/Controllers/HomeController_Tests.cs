using System.Threading.Tasks;
using ABP_VUE.Models.TokenAuth;
using ABP_VUE.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABP_VUE.Web.Tests.Controllers
{
    public class HomeController_Tests: ABP_VUEWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}