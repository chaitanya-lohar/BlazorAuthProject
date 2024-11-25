using Microsoft.JSInterop;

namespace FinalProject.Services.Extensions
{
    public static class IJSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime jSRuntime,string message) { 
            await jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
    }   
}
