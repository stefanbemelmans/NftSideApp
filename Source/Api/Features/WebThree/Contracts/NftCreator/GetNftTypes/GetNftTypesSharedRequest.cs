namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes

{
  using NftSideapp.Api.Features.Base;
  using MediatR;

public class GetNftTypesSharedRequest : BaseRequest, IRequest<GetNftTypesSharedResponse>
  {
    public const string Route = "api/getNftTypes";
  }

}