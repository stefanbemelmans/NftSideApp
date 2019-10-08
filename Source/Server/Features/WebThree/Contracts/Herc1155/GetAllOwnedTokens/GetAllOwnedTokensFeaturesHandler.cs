namespace NftSideApp.Server.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using MediatR;
  using NftSideApp.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens;
  using System.Threading;
  using System.Threading.Tasks;
  using NftSideApp.Api.Constants.AccountAddresses;
  using NftSideapp.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens;

  public class GetAllOwnedTokensServerFeaturesHandler : IRequestHandler<GetAllOwnedTokensSharedRequest, GetAllOwnedTokensSharedResponse>
  {
    IMediator Mediator { get; set; }

    public GetAllOwnedTokensServerFeaturesHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<GetAllOwnedTokensSharedResponse> Handle
    (
      GetAllOwnedTokensSharedRequest aGetAllOwnedTokensSharedRequest,
      CancellationToken aCancellationToken
    )
    {
      var aNftRequest = new GetAllOwnedTokensServiceRequest { TokenOwner = TestEthAccounts.TestEthAccountAddress};

      GetAllOwnedTokensServiceResponse response = await Mediator.Send(aNftRequest);

      return new GetAllOwnedTokensSharedResponse()
      {
        TokenIdList = response.TokenIdList
      };
    }
  }
}