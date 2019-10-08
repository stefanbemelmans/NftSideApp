namespace NftSideApp.Server.Services.WebThree.Contracts.NftCreator.ContractInstance
{
  using System.Text.Encodings;
  using System.IO;
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Instance;
  using NftSideApp.Api.Constants.ContractConstants.NftCreator;

  public class NftCreatorInstance
    {
      NethWeb3 NethWeb3 { get; set; }
      public Contract Instance { get; set; }
    
    
      public NftCreatorInstance(NethWeb3 aNethWeb3)
      {
          NethWeb3 = aNethWeb3;
          Instance = NethWeb3.Instance.Eth.GetContract( NewNftCreatorAbi.Abi, NftCreatorAddresses.NewNftCreatorRopstenAddress); 
      }
  }

}


