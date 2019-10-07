﻿namespace NftSideApp.Client.Features.Application
{
  using BlazorState;

  internal partial class ApplicationState : State<ApplicationState>
  {

    public string Name { get; private set; }
    public string Logo { get; private set; }
    public bool IsMenuExpanded { get; private set; }

    public string Version => GetType().Assembly.GetName().Version.ToString();
    
    public ApplicationState() { }

    public override void Initialize()
    {
      IsMenuExpanded = true;
      Name = "NftSideApp";
      Logo = "/images/logo.png";
    }

  }
}