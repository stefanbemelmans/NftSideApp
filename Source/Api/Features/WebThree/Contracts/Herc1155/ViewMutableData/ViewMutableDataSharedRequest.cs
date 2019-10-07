namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155
{
  using NftSideapp.Api.Features.Base;
  using MediatR;

public class ViewMutableDataSharedRequest : BaseRequest, IRequest<ViewMutableDataSharedResponse>
  {
    public const string Route = "api/viewMutableData";

    public static string RouteFactory(uint aId) => $"api/viewMutableData?ViewTokenId={aId}";
    public uint ViewTokenId { get; set; }
  }

}