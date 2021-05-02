using EPiServer.Core;

namespace EpiserverFindExample.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
