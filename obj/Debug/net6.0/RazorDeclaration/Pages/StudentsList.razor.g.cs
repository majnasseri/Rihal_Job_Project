// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StudentsBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using StudentsBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using StudentsBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using StudentsBlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using StudentsBlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentsList")]
    public partial class StudentsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\Pages\StudentsList.razor"
       

    private MudTheme Theme = new MudTheme();
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    public List<Students> students_list = new List<Students>();
    public List<CountriesMaster> countries_list = new List<CountriesMaster>();
    public List<Classes> class_list = new List<Classes>();
    private Students student = new Students();

    //Delete Dialog
    private DialogOptions dialogOptions = new() { FullWidth = true };
    private bool DeleteDialogvisible;


    protected override async Task OnInitializedAsync()
    {
        students_list = await service.GetStudentsAsync();
        countries_list  = await service.GetCountriesAsync();
        class_list  = await service.GetClassesAsync();



    }
    private void OpenDialog(int id)
    {
        student = students_list.FirstOrDefault(c => c.Id == id);
        DeleteDialogvisible = true;

    }
    private void Cancel()
    {
        DeleteDialogvisible = false;
    }



    private void SeedCountryData()
    {

        service.GenerateCountry();
        //  Navigation.NavigateTo("/");
    }
    private async Task  SeedStdntData()
    {
        try
        {
            service.GenerateStudents();

            snackBar.Add("Success", Severity.Success, config =>
          {
              config.RequireInteraction = true;
              config.ShowCloseIcon = true;
              config.Onclick = snackbar =>
                  {
                      return Task.CompletedTask;
                  };
              // config.HideTransitionDuration = 10;

          });
            students_list = await service.GetStudentsAsync();

        }
        catch (Exception ex)
        {
            snackBar.Add("Couldnt add a student!", Severity.Error);

        }

        Navigation.NavigateTo("/studentsList");

    }
    private async Task EditStudent(int id)
    {
        student = students_list.FirstOrDefault(c => c.Id == id);

        var parameters = new DialogParameters { ["student"] = student , ["DOB"]=student.DateOfBirth, 
        ["countries_list"]=countries_list,["class_list"]=class_list, ["country0"]=student.StudentCountry};

        var dialog = DialogService.Show<EditStudentDialog>("Update Student", parameters);
        var result = await dialog.Result;

        students_list = (await service.GetStudentsAsync()).ToList();

    }

    private async Task DeleteStudent()
    {
        try
        {
            service.DeleteStudent(student);
            DeleteDialogvisible = false;
            snackBar.Add("Success!", Severity.Success);

        }
        catch (Exception ex)
        {
            snackBar.Add("Couldnt delete  student!", Severity.Error);

        }
        students_list = (await service.GetStudentsAsync()).ToList();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentsService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591