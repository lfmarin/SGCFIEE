#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f289b5a6dd472efe5bd258e16789f83154df9432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosParticipacionesAcad_AcademicosPartCuerpos), @"mvc.1.0.view", @"/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml", typeof(AspNetCore.Views_AcademicosParticipacionesAcad_AcademicosPartCuerpos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f289b5a6dd472efe5bd258e16789f83154df9432", @"/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosParticipacionesAcad_AcademicosPartCuerpos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaAcadPartCuerpos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosParticipacionesAcad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarAcadPartCuerpos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexPartCuerpos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
  
    ViewData["Title"] = "AcadArticulos";
    Layout = "~/Views/Home/Principal.cshtml";
    var acade = (IEnumerable<Academicos>)ViewData["academicos"];
    var Acad = (Academicoscuerposacad)ViewData["Acad"];
    var tipo = (int)ViewData["tipo"];

#line default
#line hidden
            BeginContext(309, 697, true);
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
#line 26 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                 if (Acad != null || tipo == 1)
                                                {

#line default
#line hidden
            BeginContext(1136, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1188, 2536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f289b5a6dd472efe5bd258e16789f83154df94328229", async() => {
                BeginContext(1321, 86, true);
                WriteLiteral("\n                                                        <input name=\"cuerpoacademico\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1407, "\"", 1440, 1);
#line 29 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
WriteAttributeValue("", 1415, ViewData["idCuerpoAcad"], 1415, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1441, 591, true);
                WriteLiteral(@" type=""hidden""/>
                                                        <input name=""Lider"" value=""0"" type=""hidden""/>
                                                        <div class=""row p-b-20"">
                                                            <div class=""col-md-4 col-md-4"">
                                                                <div class=""form-group"">
                                                                    <label>Académico</label>
                                                                    <select name=""idAcademico"" class=""form-control"">
");
                EndContext();
#line 36 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                         foreach (var item in acade)
                                                                        {

#line default
#line hidden
                BeginContext(2207, 76, true);
                WriteLiteral("                                                                            ");
                EndContext();
                BeginContext(2283, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f289b5a6dd472efe5bd258e16789f83154df943210267", async() => {
                    BeginContext(2319, 41, false);
#line 38 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(2360, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2362, 50, false);
#line 38 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                    EndContext();
                    BeginContext(2412, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2414, 50, false);
#line 38 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 38 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
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
                BeginContext(2473, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                        }

#line default
#line hidden
                BeginContext(2548, 1169, true);
                WriteLiteral(@"                                                                    </select>
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
                                     ");
                WriteLiteral("                       </div>\n                                                        </div>\n                                                    ");
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
            BeginContext(3724, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 54 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3775, 710, true);
            WriteLiteral(@"                                            
                                            <div class=""table-scrollable"">
                                                <table class=""table table-striped table-bordered table-hover table-checkable order-column""  style=""width: 100%"" id=""TablaArticulos"" >
                                                    <thead>
                                                        <tr>
                                                            <th hidden></th>
                                                            <th class=""center""> Numero de personal</th>
                                                            <th class=""center""> Nombre del académico</th>
");
            EndContext();
#line 63 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                             if(tipo == 2)
                                                            {
                                                                

#line default
#line hidden
#line 65 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                 if (Acad != null)
                                                                {

#line default
#line hidden
            BeginContext(4771, 100, true);
            WriteLiteral("                                                                    <th class=\"center\"> Acción</th>\n");
            EndContext();
#line 68 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                }

#line default
#line hidden
#line 68 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                 
                                                            }

#line default
#line hidden
            BeginContext(4999, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
#line 70 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                             if(tipo == 1)
                                                            {

#line default
#line hidden
            BeginContext(5136, 96, true);
            WriteLiteral("                                                                <th class=\"center\"> Acción</th>\n");
            EndContext();
#line 73 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(5294, 183, true);
            WriteLiteral("                                                        </tr>\n                                                    </thead>\n                                                    <tbody>\n");
            EndContext();
#line 77 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(5620, 233, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\n                                                                <td hidden></td>\n                                                                <td>");
            EndContext();
            BeginContext(5854, 46, false);
#line 81 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.NumPersonal));

#line default
#line hidden
            EndContext();
            BeginContext(5900, 74, true);
            WriteLiteral("</td>\n                                                                <td>");
            EndContext();
            BeginContext(5975, 41, false);
#line 82 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(6016, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6018, 50, false);
#line 82 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6068, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6070, 50, false);
#line 82 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6120, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 83 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                 if (tipo == 2)
                                                                {
                                                                    

#line default
#line hidden
#line 85 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                     if (Acad != null)
                                                                    {

#line default
#line hidden
            BeginContext(6429, 183, true);
            WriteLiteral("                                                                        <td class=\"center\">\n                                                                            <a data-value=\"");
            EndContext();
            BeginContext(6613, 21, false);
#line 88 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                      Write(item.IdAcadCuerpoAcad);

#line default
#line hidden
            EndContext();
            BeginContext(6634, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(6646, 13, false);
#line 88 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                                       Write(item.idCuerpo);

#line default
#line hidden
            EndContext();
            BeginContext(6659, 469, true);
            WriteLiteral(@""" data-controlador=""AcademicosParticipacionesAcad"" data-accion=""EliminarAcadPartCuerpos"" data-regreso=""AcademicosPartCuerpos"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                                <i class=""fa fa-trash-o ""></i>
                                                                            </a>
                                                                        </td>
");
            EndContext();
#line 92 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                    }

#line default
#line hidden
#line 92 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(7264, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
#line 94 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                 if (tipo == 1)
                                                                {

#line default
#line hidden
            BeginContext(7410, 175, true);
            WriteLiteral("                                                                    <td class=\"center\">\n                                                                        <a data-value=\"");
            EndContext();
            BeginContext(7586, 21, false);
#line 97 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                  Write(item.IdAcadCuerpoAcad);

#line default
#line hidden
            EndContext();
            BeginContext(7607, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(7619, 13, false);
#line 97 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                                                                   Write(item.idCuerpo);

#line default
#line hidden
            EndContext();
            BeginContext(7632, 457, true);
            WriteLiteral(@""" data-controlador=""AcademicosParticipacionesAcad"" data-accion=""EliminarAcadPartCuerpos"" data-regreso=""AcademicosPartCuerpos"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                            <i class=""fa fa-trash-o ""></i>
                                                                        </a>
                                                                    </td>
");
            EndContext();
#line 101 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                                }

#line default
#line hidden
            BeginContext(8155, 66, true);
            WriteLiteral("                                                            </tr>\n");
            EndContext();
#line 103 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosParticipacionesAcad/AcademicosPartCuerpos.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(8279, 213, true);
            WriteLiteral("                                                    </tbody>\n                                                </table>\n                                            </div>\n                                            ");
            EndContext();
            BeginContext(8492, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f289b5a6dd472efe5bd258e16789f83154df943228915", async() => {
                BeginContext(8630, 102, true);
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
            BeginContext(8736, 304, true);
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
            BeginContext(9040, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f289b5a6dd472efe5bd258e16789f83154df943231037", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaAcadPartCuerpos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
