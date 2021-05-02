﻿using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ContentFolderController : PartialContentController<ContentFolder>
    {
        private readonly IContentLoader loader;

        public ContentFolderController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public override ActionResult Index(ContentFolder currentContent)
        {
            var viewmodel = new ContentFolderViewModel
            {
                CurrentFolder = currentContent,
                ItemsCount = loader.GetChildren<IContent>(currentContent.ContentLink).Count()
            };

            return PartialView(viewmodel);
        }
    }
}