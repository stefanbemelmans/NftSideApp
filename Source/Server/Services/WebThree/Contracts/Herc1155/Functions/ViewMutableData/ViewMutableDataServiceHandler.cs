namespace NftSideApp.Server.Services.WebThree.Contracts.Herc1155
{
  using System.Threading.Tasks;
  using System.Threading;
  using Nethereum.Contracts;
  using NftSideApp.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
  using MediatR;

  public class ViewMutableDataServerServiceHandler : IRequestHandler<ViewMutableDataServiceRequest, ViewMutableDataServiceResponse>
  {
    Herc1155Instance Herc1155Instance { get; set; }

    public ViewMutableDataServerServiceHandler(Herc1155Instance aHerc1155Instance)
    {
      Herc1155Instance = aHerc1155Instance;
    }

    public async Task<ViewMutableDataServiceResponse> Handle(ViewMutableDataServiceRequest aViewMutableDataServiceRequest, CancellationToken aCancellationToken)
    {
      Function<ViewMutableDataServiceRequest> aViewMutableDataFunction = Herc1155Instance.Instance.GetFunction<ViewMutableDataServiceRequest>();

      var viewMutableFunctionMessage = new ViewMutableDataServiceRequest()
      {
        ViewTokenId = aViewMutableDataServiceRequest.ViewTokenId
      };
      ViewMutableDataServiceResponse response = await aViewMutableDataFunction.CallDeserializingToObjectAsync<ViewMutableDataServiceResponse>(viewMutableFunctionMessage);

      return response;
    }
  }
}


