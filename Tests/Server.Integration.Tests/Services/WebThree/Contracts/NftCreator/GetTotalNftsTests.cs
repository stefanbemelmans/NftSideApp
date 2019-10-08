namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Contracts.NftCreator
{
  using System;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System.Threading.Tasks;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount;

  class GetTotalNftsTests
  {
    public GetTotalNftsTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }

    public async Task ShouldGetTotalNftTemplateTypes()
    { 
      // Arrange
      var getNftRequest = new GetNftCountServiceRequest();

      // Act
      GetNftCountServiceResponse response = await Mediator.Send(getNftRequest);

      //Assert
      //response.TotalNftTypes.ShouldBeGreaterThan(2);
      response.NftCount.ShouldNotBeNull();

    }
  }
}
