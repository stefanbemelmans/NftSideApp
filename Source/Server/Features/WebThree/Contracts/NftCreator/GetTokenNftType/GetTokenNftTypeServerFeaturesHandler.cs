﻿namespace NftSideApp.Server.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using MediatR;
  using NftSideapp.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType;
  using NftSideApp.Server.Services.WebThree.Contracts.NftCreator.Functions.GetTokenNftType;
  using System.Threading;
  using System.Threading.Tasks;

  public class GetTokenNftTypeServerFeaturesHandler : IRequestHandler<GetTokenNftTypeSharedRequest, GetTokenNftTypeSharedResponse>
  {
    IMediator Mediator { get; set; }

    System.Guid guid { get; set; }
    public GetTokenNftTypeServerFeaturesHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }

    public async Task<GetTokenNftTypeSharedResponse> Handle
    (
      GetTokenNftTypeSharedRequest aGetTokenNftTypeSharedRequest,
      CancellationToken aCancellationToken
    )
    {
      var aNftRequest = new GetTokenNftTypeServiceRequest { TokenId = aGetTokenNftTypeSharedRequest.TokenId };

      GetTokenNftTypeServiceResponse response = await Mediator.Send(aNftRequest);

      return new GetTokenNftTypeSharedResponse(new System.Guid())
      {
        NftId = response.NftId
      };
      
    }
  }
}