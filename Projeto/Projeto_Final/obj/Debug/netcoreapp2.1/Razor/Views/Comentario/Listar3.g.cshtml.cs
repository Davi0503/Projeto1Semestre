#pragma checksum "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "504c6e149e15b89ffcfb1f5315394db06c342f36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Listar3), @"mvc.1.0.view", @"/Views/Comentario/Listar3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Listar3.cshtml", typeof(AspNetCore.Views_Comentario_Listar3))]
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
#line 1 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
using Projeto_Final.Models;

#line default
#line hidden
#line 2 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"504c6e149e15b89ffcfb1f5315394db06c342f36", @"/Views/Comentario/Listar3.cshtml")]
    public class Views_Comentario_Listar3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(92, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98afef44e8cf428781a339e5700b11c1", async() => {
                BeginContext(98, 312, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Comentarios</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"" />
    <script src=""main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(417, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(421, 734, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71f0fe59eb5b4f5e831f99d49b615ded", async() => {
                BeginContext(427, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 17 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
     foreach (var item in ViewData["banana"] as List<ComentarioModel>)
        {
            if(item.Aprovado == true && item.Ativo == true){

#line default
#line hidden
                BeginContext(576, 77, true);
                WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(654, 16, false);
#line 23 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
               Write(item.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(670, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(738, 17, false);
#line 26 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
               Write(item.Usuario.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(755, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(823, 10, false);
#line 29 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
               Write(item.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(833, 79, true);
                WriteLiteral("\r\n                </td>               \r\n\r\n            </tr>\r\n        </table>\r\n");
                EndContext();
#line 34 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\Listar3.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(938, 210, true);
                WriteLiteral("\r\n        \r\n         \r\n        \r\n        <a href=\"/Usuario/Deslogar\">Deslogar</a>\r\n\r\n        \r\n\r\n\r\n        <footer>\r\n            <a href=\"/Usuario/Login\">Escrever comentário</a>\r\n        </footer>\r\n        \r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1155, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
