using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Shared.Pages;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EPiServer.Reference.Commerce.Site.Features.Shared.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}