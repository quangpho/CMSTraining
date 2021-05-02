using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "SVG File", Description = "Use this to upload Scalable Vector Graphic (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {
        public override Blob Thumbnail { get; set; }
    }
}