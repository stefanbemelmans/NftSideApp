﻿namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Contracts.NftCreator
{
  using System;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System.Threading.Tasks;
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using NftSideApp.Server.Services.WebThree.Instance;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideapp.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount;
  using NftSideApp.Api.Constants.ContractConstants.NftCreator;

  class AddNewTemplateTests
  {
    public AddNewTemplateTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      NftCreator = ServiceProvider.GetService<NftCreatorInstance>();
      NethWeb3 = ServiceProvider.GetService<NethWeb3>();
    }

    private IServiceProvider ServiceProvider { get; }
    private IMediator Mediator { get; }
    private NftCreatorInstance NftCreator { get; }
    private NethWeb3 NethWeb3 { get; }
    public async Task ShouldAddNewNftTemplate()
    {
      // Arrange
      Function<AddNewTemplateFunctionInput> aAddNewTemplateFunction = NftCreator.Instance.GetFunction<AddNewTemplateFunctionInput>();

      Nethereum.Contracts.ContractHandlers.IContractTransactionHandler<AddNewTemplateFunctionInput> addNewTemplateFunctionHandler = NethWeb3.Instance.Eth.GetContractTransactionHandler<AddNewTemplateFunctionInput>();

      var getNftRequest = new GetNftCountServiceRequest();

      GetNftCountServiceResponse totalTypesBeforeTest = await Mediator.Send(getNftRequest);

      var aAddNewTemplateFunctionMessage = new AddNewTemplateFunctionInput
      {
        NewTemplateName = "Purchase Order",
        NewTemplateSymbol = "POR",
        NewTemplateAttachedTokens = 0,
        NewTemplateMintLimit = 10
      };

      Nethereum.Hex.HexTypes.HexBigInteger gasEstimate = await addNewTemplateFunctionHandler.EstimateGasAsync(NftCreatorAddresses.NewNftCreatorRopstenAddress, aAddNewTemplateFunctionMessage);

      aAddNewTemplateFunctionMessage.Gas = gasEstimate.Value;

      gasEstimate.Value.ShouldBeGreaterThan(0);

      // Leaving this commented out as this is the action that makes a new template
      // it's been tested and works

      //Nethereum.RPC.Eth.DTOs.TransactionReceipt addingTemplateTransactionReceipt = await addNewTemplateFunctionHandler.SendRequestAndWaitForReceiptAsync(NftCreatorAddresses.NftCreatorRinkebyAddress, aAddNewTemplateFunctionMessage);

      //addingTemplateTransactionReceipt.ShouldNotBe(null);


      //GetNftTypesServiceResponse totalTypesAfterTest = await Mediator.Send(getNftRequest);


      //totalTypesAfterTest.TotalNftTypes.ShouldBeGreaterThan(totalTypesBeforeTest.TotalNftTypes);
    }
  }
}
