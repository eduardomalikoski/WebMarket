#pragma checksum "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4f4ab833a776dc2f2063e8cd2bcfe0fa2a070d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_ListarProduto), @"mvc.1.0.view", @"/Views/Gestao/ListarProduto.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\_ViewImports.cshtml"
using WebMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\_ViewImports.cshtml"
using WebMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4f4ab833a776dc2f2063e8cd2bcfe0fa2a070d", @"/Views/Gestao/ListarProduto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17675fdd68bf2a436863f12911cbe963bcb37ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_ListarProduto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMarket.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
  
    ViewData["Title"] = "ListarProduto";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Listar Produtos</h2>\n<hr />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4f4ab833a776dc2f2063e8cd2bcfe0fa2a070d5762", async() => {
                WriteLiteral("Criar novo Produto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<hr />



<table id=""dados"" class=""table table-striped table-bordered responsive nowrap"" style=""width:100%"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Categoria</th>
            <th>Fornecedor</th>
            <th>Preço de Custo</th>
            <th>Preço de Venda</th>
            <th>Medição</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
         foreach (var produto in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 33 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 35 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 36 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
           Write(produto.Fornecedor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>(R$)");
#nullable restore
#line 37 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
               Write(produto.PrecoDeCusto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>(R$)");
#nullable restore
#line 38 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
               Write(produto.PrecoDeVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
#nullable restore
#line 40 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
                 if (@produto.Medicao == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Litro</span>");
#nullable restore
#line 41 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
                                   }
                else if (@produto.Medicao == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Kilo</span> ");
#nullable restore
#line 43 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
                                    }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Unidade</span>");
#nullable restore
#line 45 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n\n            <td>\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1369, 2);
            WriteAttributeValue("", 1336, "/Gestao/EditarProduto/", 1336, 22, true);
#nullable restore
#line 50 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 1358, produto.Id, 1358, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\n\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4f4ab833a776dc2f2063e8cd2bcfe0fa2a070d11471", async() => {
                WriteLiteral("\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1534, "\"", 1553, 1);
#nullable restore
#line 53 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
WriteAttributeValue("", 1542, produto.Id, 1542, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    <button class=\"btn btn-danger\">Deletar</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </tr>\n");
#nullable restore
#line 58 "C:\Users\jocm\My Private Documents\codes\Estudo ASP.NET.Core.MVC\WebMarket\Views\Gestao\ListarProduto.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMarket.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
