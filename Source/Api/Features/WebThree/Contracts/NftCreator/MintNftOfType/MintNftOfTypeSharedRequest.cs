namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType
{
  using MediatR;
  using NftSideApp.Api.Features.Base;

  public class MintNftOfTypeSharedRequest : BaseRequest, IRequest<MintNftOfTypeSharedResponse>
  {
    public const string Route = "api/mintNftOfType";

    public static string RouteFactory(int aId, string aMutable, string aImmutable) => $"api/mintNftOfType?MintNftId={aId}?MutableDataString={aMutable}?ImmutableDataString={aImmutable}";
    public int MintNftId { get; set; }
    public string ImmutableDataString { get; set; }
    public string MutableDataString { get; set; }
  }

}
