#pragma checksum "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c7cb1f6bafa9d29fe8e13cd34117d3040050441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c7cb1f6bafa9d29fe8e13cd34117d3040050441", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Painel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
   
    // TODO -Pegar apenas o primeiro nome do usuarios e apresentar quando estiver logado.
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(242, 539, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
    <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">


        <ul class=""navbar-nav mr-auto"">
            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 781, "\"", 947, 2);
            WriteAttributeValue("", 789, "nav-item", 789, 8, true);
#line 17 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 797, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Index") ? "active" : "" , 798, 149, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(948, 144, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/\"><i class=\"fas fa-home\"></i> Home <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n");
            EndContext();
#line 20 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
              
                var TodasCategorias = Model.ToList();
            

#line default
#line hidden
            BeginContext(1178, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 23 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
             if (TodasCategorias != null && TodasCategorias.Count > 0)
            {

#line default
#line hidden
            BeginContext(1265, 62, true);
            WriteLiteral("                <div class=\"dropdown\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1327, "\"", 1513, 3);
            WriteAttributeValue("", 1335, "nav-link", 1335, 8, true);
            WriteAttributeValue(" ", 1343, "dropdown-toggle", 1344, 16, true);
#line 26 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 1359, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Categoria") ? "active" : "" , 1360, 153, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1514, 332, true);
            WriteLiteral(@" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                       aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-list-ul""></i> Categorias
                    </a>
                    <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
");
            EndContext();
#line 31 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                          
                            var CategoriasPrincipais = TodasCategorias.Where(a => a.CategoriaPaiId == null).ToList();
                            ViewData["TodasCategorias"] = TodasCategorias;
                        

#line default
#line hidden
            BeginContext(2096, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 35 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                         foreach (var categoria in CategoriasPrincipais)
                        {
                            

#line default
#line hidden
            BeginContext(2226, 141, false);
#line 37 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                       Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoria } }));

#line default
#line hidden
            EndContext();
#line 37 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                                                                          
                        }

#line default
#line hidden
            BeginContext(2396, 51, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
            EndContext();
#line 41 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2462, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2477, "\"", 2645, 2);
            WriteAttributeValue("", 2485, "nav-item", 2485, 8, true);
#line 42 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 2493, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Contato") ? "active" : "" , 2494, 151, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2646, 152, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/Home/Contato\"><i class=\"far fa-address-book\"></i> Contato </a>\r\n            </li>\r\n        </ul>\r\n        ");
            EndContext();
            BeginContext(2798, 873, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7cb1f6bafa9d29fe8e13cd34117d304005044113115", async() => {
                BeginContext(2837, 79, true);
                WriteLiteral("\r\n            <input class=\"form-control mr-sm-2\" type=\"search\" name=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2916, "\"", 2933, 1);
#line 47 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 2924, pesquisa, 2924, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2934, 145, true);
                WriteLiteral(" placeholder=\"pesquisar\" aria-label=\"Search\">\r\n            <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Pesquisa</button>\r\n");
                EndContext();
#line 49 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
             if (_loginCliente.GetCliente() != null)
            {


#line default
#line hidden
                BeginContext(3150, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(3166, 149, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7cb1f6bafa9d29fe8e13cd34117d304005044114578", async() => {
                    BeginContext(3247, 32, true);
                    WriteLiteral("<i class=\"fas fa-user-alt\"></i> ");
                    EndContext();
                    BeginContext(3280, 31, false);
#line 52 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                            Write(_loginCliente.GetCliente().Nome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3315, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(3365, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(3381, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7cb1f6bafa9d29fe8e13cd34117d304005044117353", async() => {
                    BeginContext(3461, 38, true);
                    WriteLiteral("<i class=\"fas fa-user-alt\"></i> Entrar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3503, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
                BeginContext(3520, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(3534, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7cb1f6bafa9d29fe8e13cd34117d304005044119676", async() => {
                    BeginContext(3605, 45, true);
                    WriteLiteral("<i class=\"fas fa-shopping-cart\"></i> Carrinho");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3654, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3671, 20, true);
            WriteLiteral("\r\n    </div>\r\n</nav>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LojaVirtual.Libraries.Login.LoginCliente _loginCliente { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
