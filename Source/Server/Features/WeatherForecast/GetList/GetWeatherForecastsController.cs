namespace NftSideApp.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using NftSideApp.Server.Features.Base;
  using NftSideApp.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Process(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}