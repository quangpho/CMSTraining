using EPiServer.Core;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;

namespace AlloyAdvanced.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(CategoryList))]
    public class HideCategoryEditorDescriptor : EditorDescriptor
    {
        //public override void ModifyMetadata(ExtendedMetadata metadata,
        //IEnumerable<Attribute> attributes)
        //{
        //    if (metadata.PropertyName == Global.SystemPropertyNames.Category)
        //    {
        //        metadata.ShowForEdit = false;
        //    }
        //    base.ModifyMetadata(metadata, attributes);
        //}
    }
}