﻿
namespace NftSideApp.Server.Integration.Tests.Services.WebThree
{
  using System;
  using System.Threading.Tasks;
  using MediatR;
  using Microsoft.Extensions.DependencyInjection;
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using NftSideApp.Server.Services.WebThree.Instance;
  using NftSideApp.Shared.Constants.ContractConstants.NftCreator;
  using Shouldly;
  class NftCreatorInstanceTests
  {
    public NftCreatorInstanceTests(TestFixture aTestFixture)
    {
      ServiceProvider = aTestFixture.ServiceProvider;
      NftCreatorInstance = ServiceProvider.GetService<NftCreatorInstance>();
    }

    private IServiceProvider ServiceProvider { get; }
    private NftCreatorInstance NftCreatorInstance { get; set; }

    public void NftCreatorInstanceIsNotNullTests() => NftCreatorInstance.Instance.ShouldNotBe(null);

    public void InstanceShouldBeAContract() => NftCreatorInstance.Instance.ShouldBeOfType<Contract>();

    public void InstanceShouldHaveCorrectEthAddress()
    {
      string address = NftCreatorInstance.Instance.Address;

      address.ShouldBe(NftCreatorAddresses.NftCreatorRinkebyAddress);

    }



  }
}
