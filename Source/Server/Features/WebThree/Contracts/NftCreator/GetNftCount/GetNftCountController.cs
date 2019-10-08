namespace NftSideApp.Server.Features.WebThree.Contracts.NftCreator.GetNftCount
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes;
  using NftSideApp.Api.Features.WebThree.Contracts.NftCreator.GetNftCount;

  [Route(GetNftCountSharedRequest.Route)]
  public class GetNftCountServerFeaturesController : BaseController<GetNftCountSharedRequest, GetNftCountSharedResponse> 
  {
    public async Task<IActionResult> Get(GetNftCountSharedRequest aRequest) => await Send(aRequest);
  }
}
