namespace NftSideApp.Client.Features.EventStream
{
  using NftSideApp.Client.Features.Base;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}