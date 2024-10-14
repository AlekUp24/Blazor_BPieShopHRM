using BPieShopHRM.State;
using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components

{
    public partial class InboxCounter
    {
        private int MessageCounter;

        [Inject]
        public ApplicationState? ApplicationState { get; set; }

        protected override void OnInitialized()
        {
            MessageCounter = new Random().Next(10);
            ApplicationState.NumberOfMessages = MessageCounter;
        }
    }
}
