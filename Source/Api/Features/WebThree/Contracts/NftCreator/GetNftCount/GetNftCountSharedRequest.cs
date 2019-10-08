namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftCount

{
  using MediatR;
  using NftSideApp.Api.Features.Base;

  public class GetNftCountSharedRequest : BaseRequest, IRequest<GetNftCountSharedResponse>
  {
    public const string Route = "api/getNftCount";
  }

}