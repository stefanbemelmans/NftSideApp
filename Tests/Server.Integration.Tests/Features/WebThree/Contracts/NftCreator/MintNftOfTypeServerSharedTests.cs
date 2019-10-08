namespace nt.Server.Integration.Tests.Features.WebThree.Contracts.NftCreator
{
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Nethereum.Contracts;
  using NftSideapp.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  using NftSideApp.Api.Constants.ContractConstants.NftCreator;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using NftSideApp.Server.Services.WebThree.Instance;
  using Shouldly;
  using System;
  using System.Threading.Tasks;

  // Below is nftType 4 for deserialization

  internal class MintNftOfTypeServerSharedTests
  {
    private IMediator Mediator { get; }

    private NethWeb3 NethWeb3 { get; }

    private NftCreatorInstance NftCreator { get; }

    private IServiceProvider ServiceProvider { get; }

    public MintNftOfTypeServerSharedTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Mediator = ServiceProvider.GetService<IMediator>();
      NftCreator = ServiceProvider.GetService<NftCreatorInstance>();
      NethWeb3 = ServiceProvider.GetService<NethWeb3>();
    }

    public async Task ShouldMintNftOfType()
    {
      // Arrange

      Function<MintNftOfTypeFunctionInput> aMintNftOfTypeFunction = NftCreator.Instance.GetFunction<MintNftOfTypeFunctionInput>();

      Nethereum.Contracts.ContractHandlers.IContractTransactionHandler<MintNftOfTypeFunctionInput> mintNftOfTypeFunctionHandler = NethWeb3.Instance.Eth.GetContractTransactionHandler<MintNftOfTypeFunctionInput>();

      var aMintNftOfTypeFunctionMessage = new MintNftOfTypeFunctionInput
      {
        NftId = 4,
        MutableDataString = "The Third Minted NFT!Take 3",
        ImmutableDataString = "This Is MintingTest 3"
      };

      Nethereum.Hex.HexTypes.HexBigInteger gasEstimate = await mintNftOfTypeFunctionHandler.EstimateGasAsync(NftCreatorAddresses.NewNftCreatorRopstenAddress, aMintNftOfTypeFunctionMessage);

      aMintNftOfTypeFunctionMessage.Gas = gasEstimate.Value;

      gasEstimate.Value.ShouldBeGreaterThan(0);
    }


    //public async Task ShouldMintNftOfTypeFromShared()
    //{
    //  // Arrange

    //  Function<MintNftOfTypeFunctionInput> aMintNftOfTypeFunction = NftCreator.Instance.GetFunction<MintNftOfTypeFunctionInput>();

    //  Nethereum.Contracts.ContractHandlers.IContractTransactionHandler<MintNftOfTypeFunctionInput> MintNftOfTypeFunctionHandler = NethWeb3.Instance.Eth.GetContractTransactionHandler<MintNftOfTypeFunctionInput>();

    //  var aMintNftOfTypeSharedRequest = new MintNftOfTypeClientAction()
    //  {
    //    MintNftId = 4,
    //    MutableDataString = "Testing Minting From Server Shared Mutable Data",
    //    ImmutableDataString = "Testing Minting From Server Shared ImMutable Data 19-8-7"
    //  };

    //  //WebThreeState SharedResponse = await Mediator.Send(aMintNftOfTypeSharedRequest);

    //  //SharedResponse.ShouldNotBe(null);
    //}

    //public async Task ShouldMintNftOfTypeFromClient()
    //{

    //  // Arrange

    //  var aMintNftOfTypeClientAction = new MintNftOfTypeClientAction()
    //  {
    //    MintNftId = 4,
    //    MutableDataString = "Testing Minting From Client Features! Here's some Mutable Data",
    //    ImmutableDataString = "Testing Minting From Client Features! Here's some  ImMutable Data 19-8-7"
    //  };

    //  WebThreeState ClientMintResponse = await Mediator.Send(aMintNftOfTypeClientAction);

    //  aMintNftOfTypeClientAction.ShouldNotBeNull();
    //  ClientMintResponse.MintingTransactionReceipt.ShouldNotBe(null);
    }

  }


