#pragma checksum "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/GameOfLife.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b01e2a237c4d88cde5701deb2e080541f7de714"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game_of_life")]
    public partial class GameOfLife : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Game of Life</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/GameOfLife.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>\r\n\r\n");
#nullable restore
#line 7 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/GameOfLife.razor"
  
    // only the first time (initial pattern)
    if (currentCount == 0) {
        // Beehive
        /*
        e.live(3, 3);
        e.live(3, 4);
        e.live(4, 2);
        e.live(4, 5);
        e.live(5, 3);
        e.live(5, 4);
        */

        // Toad
        /*
        e.live(9, 9);
        e.live(9, 10);
        e.live(9, 11);
        e.live(10, 8);
        e.live(10, 9);
        e.live(10, 10);
        */
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n\r\n<hr>\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/GameOfLife.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Next");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/GameOfLife.razor"
       
    private int currentCount = 0;
    private Data.Environment e = new Data.Environment(15, 15);
    private void IncrementCount()
    {
        currentCount++;
        //e.nextConwayStep();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
