using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_MAUI_Demos;
namespace Blazor_MAUI_Demos
{
    internal partial class SampleConfig
    {
		public List<Sample> MediaQuery { get; set; } = new List<Sample>{
             new Sample
            {
                Name = "Default Functionalities",
                Category = "Media Query",
                Directory = "MediaQuery",
                Url = "media-query/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            }
        };
    }
}