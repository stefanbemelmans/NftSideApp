namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using MediatR;
  using NftSideApp.Api.Features.Base;

  public class GetTokenNftTypeSharedRequest : BaseRequest, IRequest<GetTokenNftTypeSharedResponse>
  {
    public const string Route = "api/GetTokenNftType";

    public static string RouteFactory(int aId) => $"api/GetTokenNftType?TokenId={aId}";
    public uint TokenId { get; set; }
  }

}