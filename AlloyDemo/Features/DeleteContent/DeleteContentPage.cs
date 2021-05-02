using AlloyDemo.Models;
using AlloyDemo.Models.Pages;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyDemo.Features.DeleteContent
{
    [ContentType(DisplayName = "Delete Content", 
        GroupName = Global.GroupNames.Specialized,
        Description = "Use this to soft or hard delete content.")]
    [SiteImageUrl]
    [AvailableContentTypes(IncludeOn = new[] { typeof(StartPage) })]
    public class DeleteContentPage : SitePageData
    {
    }
}