using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Demo",  Description = "Demo")]
    public class DemoPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }
    }
}