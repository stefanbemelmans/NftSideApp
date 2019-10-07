namespace NftSideApp.Client.Features.Base.Components
{
  using static NftSideApp.Client.Features.Application.ApplicationState;

  public class ResetButtonBase : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}