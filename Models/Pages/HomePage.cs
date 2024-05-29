using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EPiServer.Reference.Commerce.Site.Features.Shared.Pages
{
    [ContentType(
      DisplayName = "Home page",
      GUID = "f3ffd56e-b456-4df4-9db3-d6744739bf23",
      Description = "The home page.",
      AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class HomePage : PageData
    {
        [CultureSpecific]
        [Display(
          Name = "Main body",
          Description = "Main body",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual XhtmlString MainBody
        {
            get;
            set;
        }
    }
}