#pragma checksum "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88fd92534415de2f970b25d157db51ebf9a4685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_Index), @"mvc.1.0.view", @"/Views/CarrinhoCompra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarrinhoCompra/Index.cshtml", typeof(AspNetCore.Views_CarrinhoCompra_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88fd92534415de2f970b25d157db51ebf9a4685", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-continuar disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-continuar-comprando"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal Subtotal = 0;

#line default
#line hidden
            BeginContext(194, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(224, 902, true);
            WriteLiteral(@"    <div class=""container"">
        <section id=""order"">
            <br />
            <br />
            <h2 class=""title-doc"">Carrinho de compras</h2>
            <div class=""alert alert-danger"" style=""display: none;"" role=""alert"">

            </div>



            <div id=""code_cart"">
                <div class=""card"">
                    <table class=""table table-hover shopping-cart-wrap"">
                        <thead class=""text-muted"">
                            <tr>
                                <th scope=""col"">Produto</th>
                                <th scope=""col"" width=""120"">Quantidade</th>
                                <th scope=""col"" width=""120"">Preço</th>
                                <th scope=""col"" width=""200"" class=""text-right"">Ação</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 34 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1215, 212, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <figure class=\"media\">\r\n                                            <div class=\"img-wrap\">\r\n");
            EndContext();
#line 40 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                 if (item.Imagens.Count > 0)
                                                {

#line default
#line hidden
            BeginContext(1556, 56, true);
            WriteLiteral("                                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1612, "\"", 1647, 1);
#line 42 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 1618, item.Imagens.First().Caminho, 1618, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1648, 32, true);
            WriteLiteral(" class=\"img-thumbnail img-sm\">\r\n");
            EndContext();
#line 43 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(1836, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1888, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d88fd92534415de2f970b25d157db51ebf9a468511341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1953, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(2006, 209, true);
            WriteLiteral("                                            </div>\r\n                                            <figcaption class=\"media-body\">\r\n                                                <h6 class=\"title text-truncate\">");
            EndContext();
            BeginContext(2216, 9, false);
#line 50 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 218, true);
            WriteLiteral("</h6>\r\n                                                <dl class=\"dlist-inline small\">\r\n                                                    <dt>Descrição: </dt>\r\n                                                    <dd>");
            EndContext();
            BeginContext(2444, 14, false);
#line 53 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                   Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2458, 503, true);
            WriteLiteral(@"</dd>
                                                </dl>
                                            </figcaption>
                                        </figure>
                                    </td>
                                    <td>
                                        <div class=""col-auto"">
                                            <div class=""input-group mb-2 control-inline"">
                                                <input type=""hidden"" class=""inputProdutoId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2961, "\"", 2977, 1);
#line 61 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 2969, item.Id, 2969, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2978, 104, true);
            WriteLiteral(" />\r\n                                                <input type=\"hidden\" class=\"inputQuantidadeEstoque\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3082, "\"", 3106, 1);
#line 62 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3090, item.Quantidade, 3090, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3107, 100, true);
            WriteLiteral(" />\r\n                                                <input type=\"hidden\" class=\"inputValorUnitario\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3207, "\"", 3226, 1);
#line 63 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3215, item.Valor, 3215, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3227, 428, true);
            WriteLiteral(@" />
                                                <div class=""input-group-prepend"">
                                                    <a href=""#"" class=""btn btn-primary diminuir""> - </a>
                                                </div>
                                                <input type=""text"" style=""width: 60px; text-align: center"" readonly=""readonly"" class=""form-control inputQuantidadeProdutoCarrinho""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3655, "\"", 3694, 1);
#line 67 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3663, item.QuantidadeProdutoCarrinho, 3663, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3695, 390, true);
            WriteLiteral(@">
                                                <div class=""input-group-append"">
                                                    <a href=""#"" class=""btn btn-primary aumentar""> + </a>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
");
            EndContext();
#line 74 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                      
                                        var ResultadoSubtotalItem = item.Valor * item.QuantidadeProdutoCarrinho;
                                        Subtotal = Subtotal + ResultadoSubtotalItem;
                                    

#line default
#line hidden
            BeginContext(4364, 171, true);
            WriteLiteral("                                    <td>\r\n                                        <div class=\"price-wrap\">\r\n                                            <var class=\"price\">");
            EndContext();
            BeginContext(4537, 35, false);
#line 80 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(ResultadoSubtotalItem.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4573, 79, true);
            WriteLiteral("</var>\r\n                                            <small class=\"text-muted\">(");
            EndContext();
            BeginContext(4653, 24, false);
#line 81 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                  Write(item.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4677, 208, true);
            WriteLiteral(" cada)</small>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td class=\"text-right\">\r\n                                        ");
            EndContext();
            BeginContext(4885, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88fd92534415de2f970b25d157db51ebf9a468519431", async() => {
                BeginContext(5000, 9, true);
                WriteLiteral(" × Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5013, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 88 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5128, 1734, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </section>
        <br />
        <br />
        <section id=""parameters"">
            <div class=""row"">
                <aside class=""col-md-4"">

                    <div id=""code_desc_align"">
                        <div class=""box"">
                            <h4 class=""subtitle-doc"">
                                Frete
                            </h4>
                            <dl class=""dlist-align"">
                                <dt>CEP: </dt>
                                <dd>
                                    <div class=""input-group"">
                                        <input type=""text"" name=""cep"" class=""form-control cep"" />
                                        <div class=""input-group-append"">
                                            <a href=""#"" class=""btn btn-outline-primary btn-calcular-frete"">OK</a>
                                        </d");
            WriteLiteral(@"iv>
                                    </div>
                                </dd>
                            </dl>
                            <div class=""container-frete""></div>
                        </div>
                    </div>
                </aside>
                <aside class=""col-md-4"">

                    <div id=""code_desc_right"">
                        <div class=""box"">
                            <h4 class=""subtitle-doc"">
                                Resumo
                            </h4>
                            <dl class=""dlist-align"">
                                <dt>Subtotal: </dt>
                                <dd class=""text-right subtotal"">");
            EndContext();
            BeginContext(6863, 22, false);
#line 129 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                           Write(Subtotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6885, 635, true);
            WriteLiteral(@"</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>Frete:</dt>
                                <dd class=""text-right frete"">R$ 0,00</dd>
                            </dl>
                            <dl class=""dlist-align"">
                                <dt>TOTAL:</dt>
                                <dd class=""text-right total"">R$ 0,00</dd>
                            </dl>
                        </div>
                    </div>
                </aside>
                <aside class=""col-md-4"">
                    <div class=""box"">
");
            EndContext();
#line 144 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                         if (_loginCliente.GetCliente() == null)
                        {

#line default
#line hidden
            BeginContext(7613, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(7641, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88fd92534415de2f970b25d157db51ebf9a468525811", async() => {
                BeginContext(7825, 9, true);
                WriteLiteral("Continuar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 146 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                                                    WriteLiteral(Url.Action("Index", "Pagamento", new { area = ""}));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7838, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 147 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(7924, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(7952, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88fd92534415de2f970b25d157db51ebf9a468529183", async() => {
                BeginContext(8048, 9, true);
                WriteLiteral("Continuar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8061, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 151 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(8090, 110, true);
            WriteLiteral("                    </div>\r\n                </aside>\r\n            </div>\r\n\r\n        </section>\r\n\r\n    </div>\r\n");
            EndContext();
#line 159 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(8212, 189, true);
            WriteLiteral("    <div class=\"container\">\r\n        <br />\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                Ainda não adicionou um produto ao seu carrinho? ");
            EndContext();
            BeginContext(8401, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88fd92534415de2f970b25d157db51ebf9a468531750", async() => {
                BeginContext(8445, 11, true);
                WriteLiteral("Clique aqui");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8460, 145, true);
            WriteLiteral(" e começe a comprar\r\n            </div>\r\n            <br />\r\n            <br />\r\n            <div class=\"offset-md-4 col-md-4\">\r\n                ");
            EndContext();
            BeginContext(8605, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88fd92534415de2f970b25d157db51ebf9a468533491", async() => {
                BeginContext(8705, 56, true);
                WriteLiteral("\r\n                    Vamos as compras\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8765, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 178 "C:\Meus Projetos - DotNet - Core\ASPNETCoreMVCLojaVirtual 2.2\LojaVirtual\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
