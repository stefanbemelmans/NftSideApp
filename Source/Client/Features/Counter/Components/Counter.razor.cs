namespace NftSideApp.Client.Features.Counter.Components
{
  using System.Threading.Tasks;
  using NftSideApp.Client.Features.Base.Components;
  using static NftSideApp.Client.Features.Counter.CounterState;

  public class CounterBase : BaseComponent
  {
    protected async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}