#pragma checksum "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09451d33450fffe0a8abd27efa3d27595663c2ea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace trabajofinal.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using trabajofinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using trabajofinal.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
