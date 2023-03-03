using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Movies.Blazor.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private static int currentCountStatic = 0;
        [CascadingParameter(Name = "Color")] public string Color { get; set; }
        private void IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
        }

        [JSInvokable]
        public static Task<int> GetCurrnetCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
