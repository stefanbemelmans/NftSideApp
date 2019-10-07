namespace NftSideApp.Client.Features.Application.Components
{
  using NftSideApp.Client.Features.Base.Components;
  using static NftSideApp.Client.Features.Application.ApplicationState;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";

    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}