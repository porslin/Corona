using Microsoft.JSInterop;

namespace Corona_Server.Helper
{
    // this class will be static so theres no need to create objects. 
    // so all the extension methods will also be static.
    public static class IJSRuntimeExtension
    {
        // first method for toastrsuccess. and then on what this will be extending, so itll be this IJSRuntime with the name jsRuntime
        // then pass the parameters, in this case 
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            // moving this from blazorjs to here.
            // removing underscore on _JSRuntime
            // matching jsRuntime name above to this
            // parameters: method, type, message -> in this order
            // the success here is matching the type in commonjs, so everything in lowercase.
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        
        // method for error
        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        // with that i have added two extension methods to the runtime
    }
}
