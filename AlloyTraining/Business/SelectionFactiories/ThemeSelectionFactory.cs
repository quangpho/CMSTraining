using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;

namespace AlloyTraining.Business.SelectionFactiories
{
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem { Value = "theme1", Text = "Orange" };
            yield return new SelectItem { Value = "theme2", Text = "Purple" };
            yield return new SelectItem { Value = "theme3", Text = "Green" };
        }
    }
}