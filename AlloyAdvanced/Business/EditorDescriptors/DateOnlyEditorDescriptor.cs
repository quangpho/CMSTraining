﻿using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyAdvanced.Business.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(DateTime), UIHint = Global.SiteUIHints.DateOnly)]
    [EditorDescriptorRegistration(TargetType = typeof(DateTime?), UIHint = Global.SiteUIHints.DateOnly)]
    public class DateOnlyEditorDescriptor: EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "dijit/form/DateTextBox";
            base.ModifyMetadata(metadata, attributes);
        }
    }
}