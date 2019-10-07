namespace NftSideApp.Client.Features.Counter
{
  using NftSideApp.Client.Features.Base;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}