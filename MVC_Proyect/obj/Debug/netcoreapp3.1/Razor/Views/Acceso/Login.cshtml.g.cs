#pragma checksum "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2be165c76882892fff3d20d85050c38c9d3e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acceso_Login), @"mvc.1.0.view", @"/Views/Acceso/Login.cshtml")]
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
#line 1 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\_ViewImports.cshtml"
using MVC_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\_ViewImports.cshtml"
using MVC_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef2be165c76882892fff3d20d85050c38c9d3e97", @"/Views/Acceso/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0376ac7c0a4dcdad7f1752c4de57466186a6cb4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Acceso_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Estilos_login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/burbujita.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("burbuja comentario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("second-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
  
    ViewData["Title"] = "Autenticacion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
Write(Html.Raw(TempData["Accion"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  \n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2be165c76882892fff3d20d85050c38c9d3e976246", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef2be165c76882892fff3d20d85050c38c9d3e976506", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css\">\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2be165c76882892fff3d20d85050c38c9d3e978603", async() => {
                WriteLiteral(@"

    <div class=""animate__animated animate__zoomInLeft"" id=""container"">

        <main>

            <section class=""img-side"">
            </section>

            <section class=""form-side"">

                <div class=""form-container"">

                    <header>
                        <div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef2be165c76882892fff3d20d85050c38c9d3e979195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                        <img src=\"https://geniosconsulting.com.mx/img/equipo/7.png\" alt=\"usuario\">\n                        <h1>WELCOME</h1>\n                    </header>\n\n");
#nullable restore
#line 34 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
                     using (Html.BeginForm("Login", "Acceso", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\n                            ");
#nullable restore
#line 37 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
                       Write(Html.TextBoxFor(u => u.Username, null, new { Placeholder = "Username", Autocomplete = "off" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                        </div>\n");
                WriteLiteral("                        <div>\n                            ");
#nullable restore
#line 41 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
                       Write(Html.TextBoxFor(u => u.Contraseña, null, new { Placeholder = "Password", Type = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;\n                        </div>\n");
                WriteLiteral("                        <button type=\"submit\"");
                BeginWriteAttribute("name", " name=\"", 1467, "\"", 1474, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"login-button\">Iniciar</button>\n");
#nullable restore
#line 45 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <a");
                BeginWriteAttribute("href", " href=\'", 1559, "\'", 1599, 1);
#nullable restore
#line 47 "C:\Users\raulg\OneDrive\Escritorio\ITLA 2021-C2\Programacion III\EmpleoR2\Primer-proyecto-master\MVC_Proyect\Views\Acceso\Login.cshtml"
WriteAttributeValue("", 1566, Url.Action("Register", "Acceso"), 1566, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <button id=\"registrarse-link\">Registrarse</button>\n                    </a>\n                </div>\n\n            </section>\n\n        </main>\n\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario1> Html { get; private set; }
    }
}
#pragma warning restore 1591
