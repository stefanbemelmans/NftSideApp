namespace NftSideApp.Server.Features.WebThree.Contracts.Herc1155.ViewMutableData
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.Herc1155;

[Route(ViewMutableDataSharedRequest.Route)]
public class ViewMutableDataServerFeaturesController : BaseController<ViewMutableDataSharedRequest, ViewMutableDataSharedResponse>
  {
    public async Task<IActionResult> Get(ViewMutableDataSharedRequest aRequest) => await Send(aRequest);
  }
}
