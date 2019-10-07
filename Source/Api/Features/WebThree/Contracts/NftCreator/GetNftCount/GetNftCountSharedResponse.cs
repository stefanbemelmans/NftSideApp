namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftCount
{
  using System;
  using NftSideapp.Api.Features.Base;

  public class GetNftCountSharedResponse : BaseResponse
  {
    public uint NftCount { get; set; }
  }
}