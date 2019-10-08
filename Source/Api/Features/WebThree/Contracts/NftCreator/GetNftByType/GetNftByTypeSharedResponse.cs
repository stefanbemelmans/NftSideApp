namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftByType
{
  using System;
  using NftSideApp.Api.Features.Base;

  public class GetNftByTypeSharedResponse : BaseResponse
  {
    public GetNftByTypeSharedResponse() { }
    public GetNftByTypeSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
    public NftTemplate NftTypeDto { get; set; }
  }
}