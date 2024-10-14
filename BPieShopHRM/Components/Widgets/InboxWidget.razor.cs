using BPieShopHRM.State;
using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components.Widgets
{
    public partial class InboxWidget
    {
        
        public int MessageCount { get; set; } = 0;

        [Inject]
        public ApplicationState? ApplicationState { get; set; }

        protected async override Task OnInitializedAsync()
        {
            MessageCount = ApplicationState.NumberOfMessages;
        }

    }
}
