
namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using NftSideApp.Api.Features.Base;

  public class AddNewTemplateSharedResponse : BaseResponse
  {
    public Nethereum.RPC.Eth.DTOs.TransactionReceipt NewTemplateTransactionReceipt { get; set; }

  }
}
