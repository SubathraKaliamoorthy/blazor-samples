using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_MAUI_Demos.Shared
{
    /// <summary>
    /// A base component to perform common functionalities.
    /// </summary>
    public class SampleBaseComponent: ComponentBase
    {
        [Inject]
        protected SampleService SampleService { get; set; }

        protected  override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            SampleService.Spinner?.Hide();
            SampleService.Spinner?.ShowModalSpinner();
        }
    }
}
