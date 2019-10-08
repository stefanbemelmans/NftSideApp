namespace NftSideApp.Server.Services.WebThree.Contracts.Herc1155.BalanceOf
{ 
  using NftSideApp.Api.Features.Base;
  using NftSideApp.Api.Features.WebThree;
  using System.Collections.Generic;
    using System.Numerics;

    public class BalanceOfServiceResponse : BaseResponse
    {
    public int Balance { get; set; }
    }
}
