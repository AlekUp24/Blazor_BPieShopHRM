using BethanysPieShopHRM.Shared.Domain;
using BPieShopHRM.Contracts.Services;
using BPieShopHRM.Services;
using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected override async void OnInitialized()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
