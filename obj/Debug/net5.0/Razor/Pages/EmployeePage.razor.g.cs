#pragma checksum "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c415a0435d82f80c48eb44a57847a67074ade97"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorfrontendsample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Blazorfrontendsample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\pemgrogramanFrontend\Blazorfrontendsample\_Imports.razor"
using Blazorfrontendsample.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
 if(Employees == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 5 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-deck");
#nullable restore
#line 12 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
     foreach (var emp in Employees)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card m-3");
            __builder.AddAttribute(5, "style", "min-width: 18rem; max-width:30%");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h3");
            __builder.AddContent(9, 
#nullable restore
#line 18 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
     emp.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 18 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
                    emp.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "class", "card-img-top img-thumbnail");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 20 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
                                              emp.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-footer text-center");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 22 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
               $"employeedetail/{emp.employeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary m-1");
            __builder.AddContent(22, "view");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 23 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"
            $"editemployee/{emp.employeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "btn btn-primary m-1");
            __builder.AddContent(27, "edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n  ");
            __builder.AddMarkupContent(29, "<a href=\"#\" class=\"btn btn-primary m-1\">delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"


}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "D:\pemgrogramanFrontend\Blazorfrontendsample\Pages\EmployeePage.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
