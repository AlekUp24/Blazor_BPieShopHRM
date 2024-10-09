using BethanysPieShopHRM.Shared.Domain;
using BPieShopHRM.Services;

namespace BPieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee Overview";

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
