#pragma checksum "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e6eb7100c98b5cd5cc2ea75645bc06f324e356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Categoria/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index))]
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
#line 2 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 5 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 6 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 7 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e6eb7100c98b5cd5cc2ea75645bc06f324e356", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d915f1a097a77fd5c8651a07be24ec99f200aa", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 22, true);
            WriteLiteral("<h1>Categoria</h1>\r\n\r\n");
            EndContext();
            BeginContext(124, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e6eb7100c98b5cd5cc2ea75645bc06f324e3566364", async() => {
                BeginContext(174, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(187, 16, true);
            WriteLiteral("\r\n<br /><br />\r\n");
            EndContext();
#line 9 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(239, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(275, 17, false);
#line 11 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(292, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(301, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
            BeginContext(331, 166, true);
            WriteLiteral("    <div class=\"table-responsive-sm\">\r\n        <table class=\"table table-borderless\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(498, 46, false);
#line 21 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(544, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(588, 48, false);
#line 22 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(680, 58, false);
#line 23 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().CategoriaPaiId));

#line default
#line hidden
            EndContext();
            BeginContext(738, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 28 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                 foreach (Categoria categoria in Model)
                {

#line default
#line hidden
            BeginContext(935, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1002, 12, false);
#line 31 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                   Write(categoria.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1050, 14, false);
#line 32 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1130, 51, false);
#line 34 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(model => categoria.CategoriaPai.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 61, true);
            WriteLiteral("\r\n                            -\r\n                            ");
            EndContext();
            BeginContext(1243, 53, false);
#line 36 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(model => categoria.CategoriaPai.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 93, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1389, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e6eb7100c98b5cd5cc2ea75645bc06f324e35613263", async() => {
                BeginContext(1470, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                        WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1513, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e6eb7100c98b5cd5cc2ea75645bc06f324e35615782", async() => {
                BeginContext(1589, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                      WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 44 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1679, 54, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(1759, 85, false);
#line 51 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
            EndContext();
#line 51 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                                                          
}
else
{

#line default
#line hidden
            BeginContext(1858, 45, true);
            WriteLiteral("    <span>Nenhum registro cadastrado</span>\r\n");
            EndContext();
#line 56 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
