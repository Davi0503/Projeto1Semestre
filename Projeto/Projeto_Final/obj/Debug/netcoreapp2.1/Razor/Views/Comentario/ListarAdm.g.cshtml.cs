#pragma checksum "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4469ac5b20128c4d1102b8fc1bc636c8cc7063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_ListarAdm), @"mvc.1.0.view", @"/Views/Comentario/ListarAdm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/ListarAdm.cshtml", typeof(AspNetCore.Views_Comentario_ListarAdm))]
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
#line 1 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
using Projeto_Final.Models;

#line default
#line hidden
#line 2 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4469ac5b20128c4d1102b8fc1bc636c8cc7063", @"/Views/Comentario/ListarAdm.cshtml")]
    public class Views_Comentario_ListarAdm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(65, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 3 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
   
    ViewBag.Title = "Depoimentos";
    Layout = "Depoimentos";
    

#line default
#line hidden
            BeginContext(142, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(169, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8c0523f446e43aa8da91d20bcab6dc1", async() => {
                BeginContext(175, 312, true);
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
            BeginContext(494, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(498, 904, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb31b6359634fec96c26bf428fd1533", async() => {
                BeginContext(504, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 21 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
         foreach (var item in ViewData["banana"] as List<ComentarioModel>)
        {
            if(item.Aprovado == false && item.Ativo == true){

#line default
#line hidden
                BeginContext(658, 77, true);
                WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(736, 7, false);
#line 27 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
               Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(743, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(811, 16, false);
#line 30 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
               Write(item.DataCriacao);

#line default
#line hidden
                EndContext();
                BeginContext(827, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(895, 17, false);
#line 33 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
               Write(item.Usuario.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(912, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(980, 10, false);
#line 36 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
               Write(item.Texto);

#line default
#line hidden
                EndContext();
                BeginContext(990, 70, true);
                WriteLiteral("\r\n                </td> \r\n                <td>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1060, "\"", 1098, 2);
                WriteAttributeValue("", 1067, "/Comentario/Aprovar?id=", 1067, 23, true);
#line 39 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
WriteAttributeValue("", 1090, item.Id, 1090, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1099, 36, true);
                WriteLiteral(">Aprovar</a>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1135, "\"", 1174, 2);
                WriteAttributeValue("", 1142, "/Comentario/Rejeitar?id=", 1142, 24, true);
#line 40 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
WriteAttributeValue("", 1166, item.Id, 1166, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1175, 117, true);
                WriteLiteral(">Rejeitar</a>\r\n                    \r\n                </td>              \r\n\r\n            </tr>\r\n\r\n\r\n        </table>\r\n");
                EndContext();
#line 48 "C:\Users\45346351841\Documents\Projetos\projeto_final\Projeto\Projeto_Final\Views\Comentario\ListarAdm.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(1318, 77, true);
                WriteLiteral("\r\n        <a href=\"/Comentario/ListarDeslog\" >Voltar para depoimentos</a>\r\n\r\n");
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
            BeginContext(1402, 11, true);
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
