namespace NftSideApp.Client.Features.ClientLoaderFeature
{
  using System;

  public class ClientLoaderTestConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}