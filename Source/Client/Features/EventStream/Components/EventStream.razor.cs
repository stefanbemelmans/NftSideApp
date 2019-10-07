namespace NftSideApp.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using NftSideApp.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;
  }
}
