namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes

{
  using MediatR;
  using NftSideApp.Api.Features.Base;

  public class GetNftTypesSharedRequest : BaseRequest, IRequest<GetNftTypesSharedResponse>
  {
    public const string Route = "api/getNftTypes";
  }

}