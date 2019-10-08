namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Contracts.Herc1155
{
  using System;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Shouldly;
  using System.Threading.Tasks;
  using NftSideApp.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
  using NftSideApp.Server.Services.WebThree.Instance;
  using Nethereum.Contracts;
  using Nethereum.RPC.Eth.DTOs;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideApp.Api.Constants.AccountAddresses;

  class ViewTokenDataTests
    {
        public ViewTokenDataTests(TestFixture aTestFixture)
        {
            ServiceProvider = aTestFixture.ServiceProvider;
            Mediator = ServiceProvider.GetService<IMediator>();
            NethWeb3 = ServiceProvider.GetService<NethWeb3>();
            Herc1155 = ServiceProvider.GetService<Herc1155Instance>();
            //NFtCreator = ServiceProvider.GetService<NftCreatorInstance>();
        }

        private IServiceProvider ServiceProvider { get; }
        private IMediator Mediator { get; }
        private NethWeb3 NethWeb3 { get; set; }
        private Herc1155Instance Herc1155 { get; set; }
        //private NftCreatorInstance NFtCreator { get; set; }

        public async Task ShouldGetTokenData()
        { // 
          // Arrange
          //var getNftRequest = new ViewTokenDataServiceRequest { ViewTokenId = 3 };"0x12833d6fADd206dEd2fcE84936d8D78326AB8EfA"
            Function viewTokenDataFunction = Herc1155.Instance.GetFunction("viewTokenData");
            // Act
            string response = await viewTokenDataFunction.CallAsync<string>(from: TestEthAccounts.TestEthAccountAddress, gas: new Nethereum.Hex.HexTypes.HexBigInteger(900000), new Nethereum.Hex.HexTypes.HexBigInteger(0), 3);
            //ViewTokenDataServiceResponse response = await Mediator.Send(getNftRequest);
            //Assert
            response.ShouldNotBe(null);
           
        }
        public async Task ShouldGetTokenDataWithFunctionMessage()
        { // 
          //  Arrange
          //Function<ViewTokenDataFunctionInput> viewTokenDataFunction = Herc1155.Instance.GetFunction<ViewTokenDataFunctionInput>();
            Function viewTokenDataFunction = Herc1155.Instance.GetFunction("viewTokenData");
      //viewTokenDataFunction.CreateCallInput(new ViewTokenDataFunctionInput()
      //{
      //    FromAddress = TestEthAccounts.TestEthAccountAddress,
      //    Gas = new Nethereum.Hex.HexTypes.HexBigInteger(900000),
      //    AmountToSend = new Nethereum.Hex.HexTypes.HexBigInteger(0),

      //    ViewTokenId = 5
      //});

      string response = await viewTokenDataFunction.CallAsync<string>(
                from: TestEthAccounts.TestEthAccountAddress,
                    gas: new Nethereum.Hex.HexTypes.HexBigInteger(900000),
                    value: new Nethereum.Hex.HexTypes.HexBigInteger(0),
                    functionInput: 3
                );
            response.ShouldNotBe(null);
           
        }

        public async Task ShouldGetTokenBalance()
        {
            Function viewBalanceFunction = Herc1155.Instance.GetFunction("balanceOf");

            CallInput CallInput = viewBalanceFunction.CreateCallInput(from: TestEthAccounts.TestEthAccountAddress, gas: new Nethereum.Hex.HexTypes.HexBigInteger(900000), new Nethereum.Hex.HexTypes.HexBigInteger(0));

            int response = await viewBalanceFunction.CallAsync<int>(TestEthAccounts.TestEthAccountAddress, 3);
            int balance = response;
            balance.ShouldNotBe(0);
        }

       

    }
}
