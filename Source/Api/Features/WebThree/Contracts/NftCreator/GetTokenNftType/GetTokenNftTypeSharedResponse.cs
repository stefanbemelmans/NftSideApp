namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using System;
  using NftSideApp.Api.Features.Base;

  public class GetTokenNftTypeSharedResponse : BaseResponse
  {
    public GetTokenNftTypeSharedResponse() { }
    public GetTokenNftTypeSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
    public uint NftId { get; set; }
  }
}