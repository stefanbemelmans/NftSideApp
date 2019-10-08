namespace NftSideApp.Server.Services.WebThree.Contracts.Herc1155.ContractInstance
{
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Instance;
  using NftSideApp.Api.Constants.ContractConstants.Herc1155;
  //using FireProj.Api.Constants.ContractConstants.Herc1155;
  public class Herc1155Instance
    {
      NethWeb3 NethWeb3 { get; set; }
      public Contract Instance { get; set; }
    
    //static StreamReader reader = new StreamReader(@"C:\mv\NewTimewarpTemplate\nt\Source\nt.Shared\Constants\ContractConstants\Herc1155\Abi.json");
    
      //readonly string NftCreatorAbi = reader.ReadToEnd();
      public Herc1155Instance(NethWeb3 aNethWeb3)
      {
        NethWeb3 = aNethWeb3;
        Instance = NethWeb3.Instance.Eth.GetContract(Herc115520ContractAbi.Abi, Herc115520Addresses.MainNetAddress);
    }
  }

}


