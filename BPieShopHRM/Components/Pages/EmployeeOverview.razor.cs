using BethanysPieShopHRM.Shared.Domain;
using BPieShopHRM.Contracts.Services;
using BPieShopHRM.Services;
using Microsoft.AspNetCore.Components;

namespace BPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee Overview";

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //await Task.Delay(1000);
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
