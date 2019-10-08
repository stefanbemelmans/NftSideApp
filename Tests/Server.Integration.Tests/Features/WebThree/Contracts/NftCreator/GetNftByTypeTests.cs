namespace nt.Server.Integration.Tests.Features.WebThree.Contracts.NftCreator
{
  using System;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using MediatR;
  using System.Threading.Tasks;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftByType;

  class GetNftByTypeTests
  {
    public GetNftByTypeTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }
    // this test is not working either
    public async Task GetNftByType()
    {
      var getNftTypeRequest = new GetNftByTypeSharedRequest() {GetNftId = 3 };

      GetNftByTypeSharedResponse response = await Mediator.Send(getNftTypeRequest);

        response.NftTypeDto.Name.ShouldMatch("TesterTemplate_0");
        response.NftTypeDto.Symbol.ShouldMatch("TT0");
        response.NftTypeDto.MintLimit.ShouldBe(1000);
    }
  }
}
