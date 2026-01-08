using C10.MasterData.Models.TokenAuth;
using C10.MasterData.Web.Controllers;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace C10.MasterData.Web.Tests.Controllers;

public class HomeController_Tests : MasterDataWebTestBase
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