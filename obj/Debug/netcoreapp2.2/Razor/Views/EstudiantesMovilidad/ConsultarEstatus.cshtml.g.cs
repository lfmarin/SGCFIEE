#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d6c7fabf011543006c6f3942e1b0b1310982c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstudiantesMovilidad_ConsultarEstatus), @"mvc.1.0.view", @"/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml", typeof(AspNetCore.Views_EstudiantesMovilidad_ConsultarEstatus))]
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
#line 1 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/_ViewImports.cshtml"
using SGCFIEE;

#line default
#line hidden
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/_ViewImports.cshtml"
using SGCFIEE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d6c7fabf011543006c6f3942e1b0b1310982c2", @"/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudiantesMovilidad_ConsultarEstatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.Calificaciones_Alumno_Movilidad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancelarEdicion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EstudiantesMovilidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
  
    Layout = "~/Views/Home/Principal.cshtml";
    var x = (String)ViewData["consejo"];

#line default
#line hidden
            BeginContext(160, 1647, true);
            WriteLiteral(@"<!DOCTYPE html>
<html>
<div class=""profile-content"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card"">
                <div class=""card-topline-green"">
                    <div class=""card-head"">
                        <header>Parametros evaluados</header>
                        
                    </div>
                </div>
                <div class=""white-box"">
                    <div class=""tab-content"">
                        <div class=""tab-pane fontawesome-demo active show"" id=""tab1"">
                            <div class=""row"">
                                <div class=""col-md-12 col-sm-12"">

                                    <div class=""card-body "" id=""bar-parent2"">
                                        <div class=""row"">
                                            <div class=""table-scrollable"">
                                                <table class=""table table-striped table-bordered table-hover table-checkable order-column"" style=""widt");
            WriteLiteral(@"h: 100%"" id=""example1"">
                                                    <thead>
                                                        <tr>
                                                            <th class=""center"">Nombre de la materia</th>
                                                            <th class=""center"">Calificacion</th>
                                                            <th class=""center"">Creditos</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
            EndContext();
#line 36 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(1950, 167, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\n                                                                <td class=\"center\">");
            EndContext();
            BeginContext(2118, 44, false);
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                                              Write(Html.DisplayFor(model => item.NombreMateria));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 89, true);
            WriteLiteral("</td>\n                                                                <td class=\"center\">");
            EndContext();
            BeginContext(2252, 43, false);
#line 40 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                                              Write(Html.DisplayFor(model => item.calificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 89, true);
            WriteLiteral("</td>\n                                                                <td class=\"center\">");
            EndContext();
            BeginContext(2385, 39, false);
#line 41 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                                              Write(Html.DisplayFor(model => item.creditos));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 72, true);
            WriteLiteral("</td>\n                                                            </tr>\n");
            EndContext();
#line 43 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(2554, 303, true);
            WriteLiteral(@"
                                                    </tbody>
                                                </table>
                                            </div>
                                            <div class=""col-md-6 col-6 b-r"">
                                                <strong>");
            EndContext();
            BeginContext(2858, 27, false);
#line 49 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesMovilidad/ConsultarEstatus.cshtml"
                                                   Write(Html.DisplayFor(model => x));

#line default
#line hidden
            EndContext();
            BeginContext(2885, 168, true);
            WriteLiteral("</strong>\n                                                <br />\n                                                <br />\n                                                ");
            EndContext();
            BeginContext(3053, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2d6c7fabf011543006c6f3942e1b0b1310982c29874", async() => {
                BeginContext(3172, 100, true);
                WriteLiteral("\n                                                Volver\n                                            ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3276, 401, true);
            WriteLiteral(@"
                                            </div>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.Calificaciones_Alumno_Movilidad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
