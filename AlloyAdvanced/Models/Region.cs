using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyAdvanced.Models
{
    [System.Flags]
    public enum Region
    {
        Unknown = 0, // 0
        Europe = 1, // 1
        UK = 2, // 2
        USA = 3, // 3
        RestOfWorld = 4 // 4
    }
}