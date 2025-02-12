#pragma checksum "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3476682c9624254871875169b0de574a1633a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu__Submenu), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/_Submenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/_Submenu.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu__Submenu))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3476682c9624254871875169b0de574a1633a4", @"/Views/Shared/Components/Menu/_Submenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu__Submenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
  
    var TodasCategorias = (List<Categoria>)ViewData["TodasCategorias"];
    var CategoriaPai = (Categoria)ViewData["CategoriaPai"];

    var CategoriasFilho = TodasCategorias.Where(a => a.CategoriaPaiId == CategoriaPai.Id);

#line default
#line hidden
#line 7 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
 if (CategoriasFilho.Count() > 0)
{

#line default
#line hidden
            BeginContext(273, 91, true);
            WriteLiteral("    <li class=\"dropdown-submenu\">\r\n        <a class=\"dropdown-item\" tabindex=\"-1\" href=\"#\">");
            EndContext();
            BeginContext(365, 17, false);
#line 10 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                   Write(CategoriaPai.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(382, 42, true);
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 12 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
             foreach (var categoriaF in CategoriasFilho)
            {
                

#line default
#line hidden
#line 14 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                 if (TodasCategorias.Where(a => a.CategoriaPaiId == categoriaF.Id).Count() > 0)
                {
                    ViewData.Remove("CategoriaPai");
                    //Apresentação do Submenu - Recursivo
                    

#line default
#line hidden
            BeginContext(747, 142, false);
#line 18 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoriaF } }));

#line default
#line hidden
            EndContext();
#line 18 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                                                                                                                                   
                }
                else
                {

#line default
#line hidden
            BeginContext(951, 58, true);
            WriteLiteral("                    <li class=\"dropdown-item\"><a href=\"#\">");
            EndContext();
            BeginContext(1010, 15, false);
#line 22 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                                                     Write(categoriaF.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 23 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                }

#line default
#line hidden
#line 23 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1070, 26, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n");
            EndContext();
#line 27 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1108, 42, true);
            WriteLiteral("    <li class=\"dropdown-item\"><a href=\"#\">");
            EndContext();
            BeginContext(1151, 17, false);
#line 30 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
                                     Write(CategoriaPai.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 31 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\_Submenu.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
