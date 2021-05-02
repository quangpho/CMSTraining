using EPiServer.Core;

namespace EpiserverSearch.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
