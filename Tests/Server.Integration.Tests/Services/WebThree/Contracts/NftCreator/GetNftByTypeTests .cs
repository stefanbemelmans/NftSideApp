﻿namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Contracts.NftCreator
{
  using System;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftByType;
  using System.Threading.Tasks;
  using NftSideApp.Server.Integration.Tests.Infrastructure;

  class GetNftByTypeTests
  {
    public GetNftByTypeTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }

    public async Task ShouldGetTotalNftTemplateTypes()
    { 
      // Arrange
      var getNftRequest = new GetNftByTypeServiceRequest { GetNftId = 4 };

      // Act
      GetNftByTypeServiceResponse response = await Mediator.Send(getNftRequest);

      //Assert
      response.Name.ShouldBeOfType<string>();

    }
  }
}
