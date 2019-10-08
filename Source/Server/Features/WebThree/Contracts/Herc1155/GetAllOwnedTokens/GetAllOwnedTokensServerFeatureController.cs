namespace NftSideApp.Server.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens;

  [Route(GetAllOwnedTokensSharedRequest.Route)]
  public class GetAllOwnedTokensServerFeaturesController : BaseController<GetAllOwnedTokensSharedRequest, GetAllOwnedTokensSharedResponse> 
  {
    public async Task<IActionResult> Get(GetAllOwnedTokensSharedRequest aRequest) => await Send(aRequest);
  }
}
