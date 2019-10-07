namespace NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetNftCount

{
  using NftSideapp.Api.Features.Base;
  using MediatR;

public class GetNftCountSharedRequest : BaseRequest, IRequest<GetNftCountSharedResponse>
  {
    public const string Route = "api/getNftCount";
  }

}