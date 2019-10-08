namespace NftSideApp.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using NftSideApp.Api.Features.Base;
  using System.Collections.Generic;

  public class GetAllOwnedTokensServiceResponse : BaseResponse
    {
    public List<uint> TokenIdList { get; set; }
    }
}
