namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using MediatR;
  using NftSideApp.Api.Features.Base;

  public class GetAllOwnedTokensSharedRequest : BaseRequest, IRequest<GetAllOwnedTokensSharedResponse>
  {
    public const string Route = "api/getAllOwnedTokens";

  }

}