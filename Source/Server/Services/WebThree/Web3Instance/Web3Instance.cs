namespace NftSideApp.Server.Services.WebThree.Instance
{
    
  using Nethereum.Web3;
  using NftSideApp.Api.Constants.AccountAddresses;
  using NftSideApp.Api.Constants.WebThree;

  public class NethWeb3
  {
    public NethWeb3()
    {
      //Instance = new Web3(testAccount.TesterAcct, Web3Endpoints.RopstenEndpoint);
      Instance = new Web3(testAccount.TesterAcct, Web3Endpoints.MainNetEndpoint);
    }

    public Web3 Instance { get; set; }
    public TestEthAccounts testAccount = new TestEthAccounts();
  }

}
