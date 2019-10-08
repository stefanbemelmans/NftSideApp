namespace NftSideApp.Server.Features.WebThree.Contracts.NftCreator.BalanceOf
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.Herc1155.BalanceOf;

  [Route(BalanceOfSharedRequest.Route)]
  public class BalanceOfServerFeaturesController : BaseController<BalanceOfSharedRequest, BalanceOfSharedResponse> 
  {
    public async Task<IActionResult> Get(BalanceOfSharedRequest aRequest) => await Send(aRequest);
  }
}
