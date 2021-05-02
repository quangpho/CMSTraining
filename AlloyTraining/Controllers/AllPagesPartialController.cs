using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using AlloyTraining.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Full }, AvailableWithoutTag = true)]
    public class AllPagesPartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Full, model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Wide }, AvailableWithoutTag = true)]
    public class AllPagesWidePartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Wide, model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Narrow }, AvailableWithoutTag = true)]
    public class AllPagesNarrowPartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Narrow, model: PageViewModel.Create(currentPage));
        }
    }
}