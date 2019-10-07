namespace NftSideApp.Client.Features.Application.Components
{
  using NftSideApp.Client.Features.Base.Components;

  public class SideBarBase: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  