namespace NftSideApp.Server.Features.WebThree.Contracts.NftCreator.GetNftCount
{
  using System.Threading;
  using System.Threading.Tasks;
  using MediatR;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount;
  using NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftCount;

  public class GetNftCountHandler : IRequestHandler<GetNftCountSharedRequest, GetNftCountSharedResponse>
  {
    IMediator Mediator { get; set; }

    public GetNftCountHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<GetNftCountSharedResponse> Handle
    (
      GetNftCountSharedRequest aGetNftCountSharedRequest,
      CancellationToken aCancellationToken
    )
    {

      GetNftCountServiceResponse response = await Mediator.Send(new GetNftCountServiceRequest());



      return new GetNftCountSharedResponse
      {
        NftCount = response.NftCount
      };
    }
  }
}