#pragma checksum "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\Shared\TarefaIndividual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7386490458b2e69991ba3dcd472cde84df53bae1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Tarefas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas;

#line default
#line hidden
#line 7 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Shared;

#line default
#line hidden
#line 8 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\_Imports.razor"
using Blazor_Tarefas.Entidades;

#line default
#line hidden
    public class TarefaIndividual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "C:\_blazor\Blazor_Tarefas\Blazor_Tarefas\Shared\TarefaIndividual.razor"
      
    [Parameter] public Tarefa item { get; set; }
    //passagem de um evento como parametro
    [Parameter] public EventCallback<Tarefa> RemoverTarefa { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
