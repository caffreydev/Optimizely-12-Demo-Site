using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Shared.Pages;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EPiServer.Reference.Commerce.Site.Features.Shared.Controllers
{
    public class HomePageController : PageController<HomePage>
    {
        [HttpGet]
        public IActionResult Index(HomePage currentPage)
        {
            return View(currentPage);
        }
    }
}