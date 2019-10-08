namespace NftSideApp.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using MediatR;

  public class GetAllOwnedTokensServiceRequest : IRequest<GetAllOwnedTokensServiceResponse>
    {
    public string TokenOwner { get; set; }
    }
}
