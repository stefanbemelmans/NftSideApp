namespace NftSideApp.Client.Features.Counter
{
  using NftSideApp.Client.Features.Base;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}