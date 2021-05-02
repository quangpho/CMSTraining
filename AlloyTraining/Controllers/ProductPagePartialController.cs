using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Web.Mvc;
using System.Web.Mvc;
using AlloyTraining.Models.ViewModels;

namespace AlloyTraining.Controllers
{
    public class ProductPagePartialController : PartialContentController<ProductPage>
    {
        public override ActionResult Index(ProductPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(PageViewModel.Create(currentPage));
        }
    }
}