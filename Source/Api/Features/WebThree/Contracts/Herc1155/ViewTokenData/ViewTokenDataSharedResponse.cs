namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using System;
  using NftSideApp.Api.Features.Base;

  public class ViewTokenDataSharedResponse : BaseResponse
    {
        public ViewTokenDataSharedResponse() { }
        public ViewTokenDataSharedResponse(Guid aRequestId)
        {
            RequestId = aRequestId;
        }
        public string TokenDataString { get; set; }
        // Token Type will determine what object to use to deserialize the data
        //public uint TokenNftType { get; set; }
    }
}
