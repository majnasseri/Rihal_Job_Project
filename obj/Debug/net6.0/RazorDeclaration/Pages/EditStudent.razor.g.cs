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
    [Microsoft.AspNetCore.Components.RouteAttribute("/stdudent/{Id}")]
    public partial class EditStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\ita466\source\Workspaces\StudentsBlazorApp\Pages\EditStudent.razor"
       
    [Parameter]
    public String Id { get; set; }
    private Students studentD { get; set; }
    protected override void OnInitialized()
    {
        studentD = service.GetStudentsById(int.Parse(Id));
        
    }
    private void submitForm()
    {
        //if (editContext is null)
        //{
        //    throw new ArgumentNullException(nameof(editContext));
        //}

        service.UpdateStudent(studentD);
        Navigation.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentsService service { get; set; }
    }
}
#pragma warning restore 1591
