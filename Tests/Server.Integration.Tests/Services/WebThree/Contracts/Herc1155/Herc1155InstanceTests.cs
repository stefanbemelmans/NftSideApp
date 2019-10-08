
namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Contracts.Herc1155
{
  using System;
  using Microsoft.Extensions.DependencyInjection;
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
  using Shouldly;
  using NftSideApp.Server.Integration.Tests.Infrastructure;
  using NftSideApp.Api.Constants.ContractConstants.Herc1155;

  class Herc1155InstanceTests
  {
    public Herc1155InstanceTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      Herc1155Instance = ServiceProvider.GetService<Herc1155Instance>();
    }

    private IServiceProvider ServiceProvider { get; }
    private Herc1155Instance Herc1155Instance { get; set; }

    public void Herc1155InstanceIsNotNullTests() => Herc1155Instance.Instance.ShouldNotBe(null);

    public void InstanceShouldBeAContract() => Herc1155Instance.Instance.ShouldBeOfType<Contract>();

    public void InstanceShouldHaveCorrectEthAddress()
    {
      string address = Herc1155Instance.Instance.Address;

      address.ShouldBe(Herc115520Addresses.MainNetAddress);

    }



  }
}
