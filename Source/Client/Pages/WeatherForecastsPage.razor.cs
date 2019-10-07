namespace NftSideApp.Client.Pages
{
  using System.Threading.Tasks;
  using NftSideApp.Client.Features.Base.Components;
  using static NftSideApp.Client.Features.WeatherForecast.WeatherForecastsState;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new FetchWeatherForecastsAction());
  }
}