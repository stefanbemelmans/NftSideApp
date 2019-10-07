namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using NftSideapp.Api.Features.Base;
  using MediatR;

public class GetAllOwnedTokensSharedRequest : BaseRequest, IRequest<GetAllOwnedTokensSharedResponse>
  {
    public const string Route = "api/getAllOwnedTokens";

  }

}