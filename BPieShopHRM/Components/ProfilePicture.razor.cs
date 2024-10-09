using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
