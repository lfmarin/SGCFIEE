#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosPublicaciones_AcademicosTrabajosRecep), @"mvc.1.0.view", @"/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml", typeof(AspNetCore.Views_AcademicosPublicaciones_AcademicosTrabajosRecep))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae", @"/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosPublicaciones_AcademicosTrabajosRecep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaAcadTrabajosRecep>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosPublicaciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarAcadTrabajosRecep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexTrabajoRecep", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/table/table_data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
  
    ViewData["Title"] = "AcadArticulos";
    Layout = "~/Views/Home/Principal.cshtml";
    var acade = (IEnumerable<Academicos>)ViewData["academicos"];

#line default
#line hidden
            BeginContext(217, 696, true);
            WriteLiteral(@"
<!DOCTYPE html>
<html>
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card card-box"">
                <div class=""card-topline-green card-head"">
                    <header>COLABORADORES</header>
                </div>
                <div class=""white-box"">
                    <div class=""tab-content"">
                        <div class=""tab-pane active fontawesome-demo"" id=""tab1"">
                            <div id=""Artículos"">
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""card-body "">
                                            ");
            EndContext();
            BeginContext(913, 2229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae7670", async() => {
                BeginContext(1042, 71, true);
                WriteLiteral("\n                                                <input name=\"trabajos\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1113, "\"", 1144, 1);
#line 24 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
WriteAttributeValue("", 1121, ViewData["idTrabajos"], 1121, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1145, 449, true);
                WriteLiteral(@" type=""hidden""/>
                                                <div class=""row p-b-20"">
                                                    <div class=""col-md-4 col-md-4"">
                                                        <div class=""form-group"">
                                                            <label>Académico</label>
                                                            <select name=""idAcademico"" class=""form-control"">
");
                EndContext();
#line 30 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                 foreach (var item in acade)
                                                                {

#line default
#line hidden
                BeginContext(1753, 68, true);
                WriteLiteral("                                                                    ");
                EndContext();
                BeginContext(1821, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae9511", async() => {
                    BeginContext(1857, 41, false);
#line 32 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(1898, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1900, 50, false);
#line 32 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                                                             Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                    EndContext();
                    BeginContext(1950, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1952, 50, false);
#line 32 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                                                                                                                 Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                       WriteLiteral(item.IdAcademicos);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2011, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 33 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                }

#line default
#line hidden
                BeginContext(2078, 1057, true);
                WriteLiteral(@"                                                            </select>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""row p-b-20"">
                                                    <div class=""col-md-2 col-sm-6 col-2"">
                                                        <div class=""btn-group"">
                                                            <button type=""submit"" class=""btn btn-success btn-sm m-b-10"" name=""Guardar"" style=""float:right"">
                                                                Académico<i class=""fa fa-plus"" style=""color:white""></i>
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
           ");
                WriteLiteral("                                 ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(3142, 864, true);
            WriteLiteral(@"
                                            <div class=""table-scrollable"">
                                                <table class=""table table-striped table-bordered table-hover table-checkable order-column""  style=""width: 100%"" id=""TablaArticulos"" >
                                                    <thead>
                                                        <tr>
                                                            <th class=""center""> Numero de personal</th>
                                                            <th class=""center""> Nombre del académico</th>
                                                            <th class=""center""> Acción</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
            EndContext();
#line 58 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(4149, 152, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\n                                                                <td>");
            EndContext();
            BeginContext(4302, 46, false);
#line 61 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.NumPersonal));

#line default
#line hidden
            EndContext();
            BeginContext(4348, 74, true);
            WriteLiteral("</td>\n                                                                <td>");
            EndContext();
            BeginContext(4423, 41, false);
#line 62 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(4464, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4466, 50, false);
#line 62 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(4516, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4518, 50, false);
#line 62 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(4568, 173, true);
            WriteLiteral("</td>\n                                                                <td class=\"center\">\n                                                                    <a data-value=\"");
            EndContext();
            BeginContext(4742, 19, false);
#line 64 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                              Write(item.IdAcadTrabajos);

#line default
#line hidden
            EndContext();
            BeginContext(4761, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(4773, 15, false);
#line 64 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                                                                             Write(item.IdTrabajos);

#line default
#line hidden
            EndContext();
            BeginContext(4788, 509, true);
            WriteLiteral(@""" data-controlador=""AcademicosPublicaciones"" data-accion=""EliminarAcadTrabajosRecep"" data-regreso=""AcademicosTrabajosRecep"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                        <i class=""fa fa-trash-o ""></i>
                                                                    </a>
                                                                </td>
                                                            </tr>
");
            EndContext();
#line 69 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosPublicaciones/AcademicosTrabajosRecep.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(5355, 213, true);
            WriteLiteral("                                                    </tbody>\n                                                </table>\n                                            </div>\n                                            ");
            EndContext();
            BeginContext(5568, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae21483", async() => {
                BeginContext(5701, 102, true);
                WriteLiteral("\n                                                Regresar\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5807, 304, true);
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
</html>

");
            EndContext();
            BeginContext(6111, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca398f23e12b2d4251d2f0f9cb0cc2dc182c72ae23605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaAcadTrabajosRecep>> Html { get; private set; }
    }
}
#pragma warning restore 1591
