namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes
{
  using System;
  using NftSideApp.Api.Features.Base;

  public class GetNftTypesSharedResponse : BaseResponse
  {
    public GetNftTypesSharedResponse() { }

    public GetNftTypesSharedResponse(Guid aRequestId)
    {
      
      RequestId = aRequestId;
    }

    public uint TotalNftTypes { get; set; }
  }
}