namespace NftSideApp.Server.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using NftSideApp.Api.Features.WebThree.Contracts.Herc1155;
    using NftSideApp.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData;

    [Route(ViewTokenDataSharedRequest.Route)]
public class ViewTokenDataServerFeaturesController : BaseController<ViewTokenDataSharedRequest, ViewTokenDataSharedResponse>
  {
    public async Task<IActionResult> Get(ViewTokenDataSharedRequest aRequest) => await Send(aRequest);
  }
}
