#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bea17a6de169f200e8b64258b8f1cff891b453a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosComisiones_AcademicosJurOposicion), @"mvc.1.0.view", @"/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml", typeof(AspNetCore.Views_AcademicosComisiones_AcademicosJurOposicion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bea17a6de169f200e8b64258b8f1cff891b453a5", @"/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosComisiones_AcademicosJurOposicion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaAcadJurOposicion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosComisiones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarAcadJurOposicion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexJurOposicion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
  
    ViewData["Title"] = "AcadArticulos";
    Layout = "~/Views/Home/Principal.cshtml";
    var acade = (IEnumerable<Academicos>)ViewData["academicos"];
    var Acad = (Academicosjuroposicion)ViewData["Acad"];
    var tipo = (int)ViewData["tipo"];

#line default
#line hidden
            BeginContext(311, 654, true);
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
#line 27 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                 if (Acad != null || tipo == 1)
                                                {

#line default
#line hidden
            BeginContext(1095, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1147, 2512, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea17a6de169f200e8b64258b8f1cff891b453a58109", async() => {
                BeginContext(1272, 77, true);
                WriteLiteral("\n                                                        <input name=\"jurado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1349, "\"", 1375, 1);
#line 30 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
WriteAttributeValue("", 1357, ViewData["idJur"], 1357, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1376, 591, true);
                WriteLiteral(@" type=""hidden""/>
                                                        <input name=""Lider"" value=""0"" type=""hidden""/>
                                                        <div class=""row p-b-20"">
                                                            <div class=""col-md-4 col-md-4"">
                                                                <div class=""form-group"">
                                                                    <label>Académico</label>
                                                                    <select name=""idAcademico"" class=""form-control"">
");
                EndContext();
#line 37 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                         foreach (var item in acade)
                                                                        {

#line default
#line hidden
                BeginContext(2142, 76, true);
                WriteLiteral("                                                                            ");
                EndContext();
                BeginContext(2218, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea17a6de169f200e8b64258b8f1cff891b453a510115", async() => {
                    BeginContext(2254, 41, false);
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(2295, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2297, 50, false);
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                    EndContext();
                    BeginContext(2347, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2349, 50, false);
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
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
                BeginContext(2408, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 40 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                        }

#line default
#line hidden
                BeginContext(2483, 1169, true);
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
            BeginContext(3659, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 55 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3710, 710, true);
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
#line 64 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                             if(tipo == 2)
                                                            {
                                                                

#line default
#line hidden
#line 66 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                 if (Acad != null)
                                                                {

#line default
#line hidden
            BeginContext(4706, 100, true);
            WriteLiteral("                                                                    <th class=\"center\"> Acción</th>\n");
            EndContext();
#line 69 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                }

#line default
#line hidden
#line 69 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                 
                                                            }

#line default
#line hidden
            BeginContext(4934, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
#line 71 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                             if(tipo == 1)
                                                            {

#line default
#line hidden
            BeginContext(5071, 96, true);
            WriteLiteral("                                                                <th class=\"center\"> Acción</th>\n");
            EndContext();
#line 74 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(5229, 183, true);
            WriteLiteral("                                                        </tr>\n                                                    </thead>\n                                                    <tbody>\n");
            EndContext();
#line 78 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(5555, 233, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\n                                                                <td hidden></td>\n                                                                <td>");
            EndContext();
            BeginContext(5789, 46, false);
#line 82 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.NumPersonal));

#line default
#line hidden
            EndContext();
            BeginContext(5835, 74, true);
            WriteLiteral("</td>\n                                                                <td>");
            EndContext();
            BeginContext(5910, 41, false);
#line 83 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(5951, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5953, 50, false);
#line 83 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6003, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6005, 50, false);
#line 83 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6055, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 84 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                 if (tipo == 2)
                                                                {
                                                                    

#line default
#line hidden
#line 86 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                     if (Acad != null)
                                                                    {

#line default
#line hidden
            BeginContext(6364, 183, true);
            WriteLiteral("                                                                        <td class=\"center\">\n                                                                            <a data-value=\"");
            EndContext();
            BeginContext(6548, 17, false);
#line 89 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                      Write(item.IdAcadJurOpo);

#line default
#line hidden
            EndContext();
            BeginContext(6565, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(6577, 13, false);
#line 89 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                                   Write(item.IdJurado);

#line default
#line hidden
            EndContext();
            BeginContext(6590, 462, true);
            WriteLiteral(@""" data-controlador=""AcademicosComisiones"" data-accion=""EliminarAcadJurOposicion"" data-regreso=""AcademicosJurOposicion"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                                <i class=""fa fa-trash-o ""></i>
                                                                            </a>
                                                                        </td>
");
            EndContext();
#line 93 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                    }

#line default
#line hidden
#line 93 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(7188, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
#line 95 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                 if (tipo == 1)
                                                                {

#line default
#line hidden
            BeginContext(7334, 175, true);
            WriteLiteral("                                                                    <td class=\"center\">\n                                                                        <a data-value=\"");
            EndContext();
            BeginContext(7510, 17, false);
#line 98 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                  Write(item.IdAcadJurOpo);

#line default
#line hidden
            EndContext();
            BeginContext(7527, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(7539, 13, false);
#line 98 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                                                               Write(item.IdJurado);

#line default
#line hidden
            EndContext();
            BeginContext(7552, 450, true);
            WriteLiteral(@""" data-controlador=""AcademicosComisiones"" data-accion=""EliminarAcadJurOposicion"" data-regreso=""AcademicosJurOposicion"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                            <i class=""fa fa-trash-o ""></i>
                                                                        </a>
                                                                    </td>
");
            EndContext();
#line 102 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                                }

#line default
#line hidden
            BeginContext(8068, 66, true);
            WriteLiteral("                                                            </tr>\n");
            EndContext();
#line 104 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/AcademicosComisiones/AcademicosJurOposicion.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(8192, 213, true);
            WriteLiteral("                                                    </tbody>\n                                                </table>\n                                            </div>\n                                            ");
            EndContext();
            BeginContext(8405, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea17a6de169f200e8b64258b8f1cff891b453a528509", async() => {
                BeginContext(8535, 102, true);
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
            BeginContext(8641, 304, true);
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
            BeginContext(8945, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea17a6de169f200e8b64258b8f1cff891b453a530631", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaAcadJurOposicion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
