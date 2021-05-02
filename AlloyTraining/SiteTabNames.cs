using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlloyTraining
{
    public static class SiteTabNames
    {
        [Display(Order = 10)]
        [RequiredAccess(EPiServer.Security.AccessLevel.Edit)]
        public const string SEO = "SEO";
        [Display(Order = 20)]
        [RequiredAccess(EPiServer.Security.AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
    }
}