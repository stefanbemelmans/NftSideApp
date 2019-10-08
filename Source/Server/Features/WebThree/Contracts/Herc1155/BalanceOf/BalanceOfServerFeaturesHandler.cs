namespace NftSideApp.Server.Features.WebThree.Contracts.Herc1155.BalanceOf
{
  using MediatR;
  using NftSideApp.Api.Features.WebThree.Contracts.Herc1155.BalanceOf;
  using NftSideApp.Server.Services.WebThree.Contracts.Herc1155.BalanceOf;
  using System.Threading;
  using System.Threading.Tasks;

  public class BalanceOfServerFeaturesHandler : IRequestHandler<BalanceOfSharedRequest, BalanceOfSharedResponse>
  {
    IMediator Mediator { get; set; }

    public BalanceOfServerFeaturesHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<BalanceOfSharedResponse> Handle
    (
      BalanceOfSharedRequest aBalanceOfSharedRequest,
      CancellationToken aCancellationToken
    )
    {
      BalanceOfServiceResponse response = await Mediator.Send(new BalanceOfServiceRequest()
      {
          TokenId = aBalanceOfSharedRequest.ViewTokenId
      });

      return new BalanceOfSharedResponse()
      {
        Balance = response.Balance
      };
    }
  }
}