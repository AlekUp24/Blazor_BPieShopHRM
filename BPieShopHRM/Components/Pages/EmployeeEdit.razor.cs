using BethanysPieShopHRM.Shared.Domain;
using BPieShopHRM.Contracts.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BPieShopHRM.Components.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Inject]
        public ICountryDataService? CountryDataService { get; set; }

        [Inject]
        public IJobCategoryDataService? JobCategoryDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int EmployeeId { get; set; }

        [SupplyParameterFromForm]
        public Employee Employee { get; set; } = new();

        public List<Country> Countries { get; set; } = [];
        public List<JobCategory> JobCategories { get; set; } = [];

        protected bool Saved;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;


        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Countries = (await CountryDataService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();

            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
        }

        private IBrowserFile selectedFile;

        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFile = e.File;
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            if (selectedFile != null)//take first image
            {
                var file = selectedFile;
                Stream stream = file.OpenReadStream();
                MemoryStream ms = new();
                await stream.CopyToAsync(ms);
                stream.Close();

                Employee.ImageName = file.Name;
                Employee.ImageContent = ms.ToArray();
            }

            await EmployeeDataService.UpdateEmployee(Employee);
            Saved = true;
            StatusClass = "alert-success";
            Message = "Employee updated successfuly.";
        }

        protected void HandleInvalidSubmit() 
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);

            StatusClass = "alert-success";
            Message = "Employee deleted successfuly.";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }

    }
}
