using BPieShopHRM.Contracts.Services;
using BPieShopHRM.Services;
using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components.Widgets
{
    public partial class EmployeeCountWidget
    {
        public int EmployeeCounter { get; set; }

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            EmployeeCounter = (await EmployeeDataService.GetAllEmployees()).Count();
        }
    }
}
