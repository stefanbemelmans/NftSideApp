namespace NftSideApp.EndToEnd.Tests.Infrastructure
{
  using NftSideApp.Client.Features.ClientLoaderFeature;
  using System;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
