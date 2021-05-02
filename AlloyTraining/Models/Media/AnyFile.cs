using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File", Description = "Use this to upload any type of file")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class AnyFile : MediaData
    {
 
    }
}