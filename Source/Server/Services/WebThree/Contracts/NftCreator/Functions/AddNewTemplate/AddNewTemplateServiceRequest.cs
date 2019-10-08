namespace NftSideApp.Server.Services.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using MediatR;


  public class AddNewTemplateServiceRequest : IRequest<AddNewTemplateServiceResponse>
    {
    public string NewTemplateName { get; set; }
    public string NewTemplateSymbol { get; set; }
    public uint NewTemplateMintLimit { get; set; }
    public uint NewTemplateAttachedTokens { get; set; }
  }
}
