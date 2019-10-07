namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155.BalanceOf
{
  using System;
  using NftSideApp.Api.Features.Base;

  public class BalanceOfSharedResponse : BaseResponse
  {
    public BalanceOfSharedResponse() { }

    public BalanceOfSharedResponse(Guid aRequestId)
    {
      
      RequestId = aRequestId;
    }

    public int Balance { get; set; }
  }
}