namespace NftSideApp.Server.Integration.Tests.Services.WebThree.Account
{
  using Shouldly;
  using NftSideApp.Api.Constants.AccountAddresses;

  class AccountInstanceTests
  {
    readonly TestEthAccounts tester = new TestEthAccounts();

    public void AcctInstanceTests() => tester.TesterAcct.ShouldNotBe(null);
  }
}
