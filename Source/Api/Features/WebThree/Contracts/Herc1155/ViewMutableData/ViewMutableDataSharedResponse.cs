namespace NftSideapp.Api.Features.WebThree.Contracts.Herc1155
{
    using System;
    using NftSideapp.Api.Features.Base;

    public class ViewMutableDataSharedResponse : BaseResponse
    {
        public ViewMutableDataSharedResponse() { }
        public ViewMutableDataSharedResponse(Guid aRequestId)
        {
            RequestId = aRequestId;
        }
        public string MutableDataString { get; set; }
    }
}