namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using System;
  using System.Collections.Generic;
  using NftSideapp.Api.Features.Base;

  public class GetAllOwnedTokensSharedResponse : BaseResponse
  {
    public GetAllOwnedTokensSharedResponse() { }

    public GetAllOwnedTokensSharedResponse(Guid aRequestId)
    {
      
      RequestId = aRequestId;
    }

    public List<uint> TokenIdList { get; set; }
  }
}