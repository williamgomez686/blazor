// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/infwilliam/pruebas/blazor/_Imports.razor"
using blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/infwilliam/pruebas/blazor/Pages/Prueba.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/infwilliam/pruebas/blazor/Pages/Prueba.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/infwilliam/pruebas/blazor/Pages/Prueba.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/infwilliam/pruebas/blazor/Pages/Prueba.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prueba")]
    public partial class Prueba : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/home/infwilliam/pruebas/blazor/Pages/Prueba.razor"
       
    private TodoItem[] todoItems;
    TodoItem res = new TodoItem();

    protected override async Task OnInitializedAsync() => 
        todoItems = await Http.GetFromJsonAsync<TodoItem[]>("https://localhost:7001/api/Api");
        //res = await Http.GetFromJsonAsync<TodoItem>("https://localhost:7001/api/Api");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
