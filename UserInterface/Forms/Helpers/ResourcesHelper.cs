using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.UserInterface.Forms.Helpers
{
    public static class ResourcesHelper
    {
        public const string CloseButtonName = "close_button.png";
        public static string ResourcesFilePath 
            = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
 
    }
}
