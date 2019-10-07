namespace NftSideApp.Client.Features.Application.Components
{
  using NftSideApp.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
