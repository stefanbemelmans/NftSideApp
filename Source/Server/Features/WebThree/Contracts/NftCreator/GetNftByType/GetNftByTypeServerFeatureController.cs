namespace NftSideApp.Server.Features.WebThree.Contracts.NftCreator.GetNftByType
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.NftCreator.GetNftByType;

  [Route(GetNftByTypeSharedRequest.Route)]
  public class GetNftByTypeServerFeaturesController : BaseController<GetNftByTypeSharedRequest, GetNftByTypeSharedResponse> 
  {
    public async Task<IActionResult> Get(GetNftByTypeSharedRequest aRequest) => await Send(aRequest);
  }
}
