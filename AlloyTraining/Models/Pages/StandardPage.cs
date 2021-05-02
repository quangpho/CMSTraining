﻿using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard", GroupName = SiteGroupNames.Common, Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) }, Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }
        public virtual EmployeeBlock Author { get; set; }
    }
}