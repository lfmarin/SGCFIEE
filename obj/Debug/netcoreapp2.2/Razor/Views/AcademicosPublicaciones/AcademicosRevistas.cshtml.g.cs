#pragma checksum "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3795068209de13b1c868af7d5d53bef9c7b3c43b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosPublicaciones_AcademicosRevistas), @"mvc.1.0.view", @"/Views/AcademicosPublicaciones/AcademicosRevistas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosPublicaciones/AcademicosRevistas.cshtml", typeof(AspNetCore.Views_AcademicosPublicaciones_AcademicosRevistas))]
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
#line 1 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE;

#line default
#line hidden
#line 2 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3795068209de13b1c868af7d5d53bef9c7b3c43b", @"/Views/AcademicosPublicaciones/AcademicosRevistas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosPublicaciones_AcademicosRevistas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaAcadRevistas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosPublicaciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarAcadRevistas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexRevistas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
  
    ViewData["Title"] = "AcadArticulos";
    Layout = "~/Views/Home/Principal.cshtml";
    var acade = (IEnumerable<Academicos>)ViewData["academicos"];
    var Acad = (Academicorevistas)ViewData["Acad"];
    var tipo = (int)ViewData["tipo"];

#line default
#line hidden
            BeginContext(310, 668, true);
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
#line 25 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                 if (Acad != null || tipo == 1)
                                                {

#line default
#line hidden
            BeginContext(1110, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1162, 2543, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3795068209de13b1c868af7d5d53bef9c7b3c43b8186", async() => {
                BeginContext(1286, 80, true);
                WriteLiteral("\r\n                                                        <input name=\"revistas\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1366, "\"", 1397, 1);
#line 28 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
WriteAttributeValue("", 1374, ViewData["idRevistas"], 1374, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1398, 598, true);
                WriteLiteral(@" type=""hidden""/>
                                                        <input name=""Lider"" value=""0"" type=""hidden""/>
                                                        <div class=""row p-b-20"">
                                                            <div class=""col-md-4 col-md-4"">
                                                                <div class=""form-group"">
                                                                    <label>Académico</label>
                                                                    <select name=""idAcademico"" class=""form-control"">
");
                EndContext();
#line 35 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                         foreach (var item in acade)
                                                                        {

#line default
#line hidden
                BeginContext(2173, 76, true);
                WriteLiteral("                                                                            ");
                EndContext();
                BeginContext(2249, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3795068209de13b1c868af7d5d53bef9c7b3c43b10230", async() => {
                    BeginContext(2285, 41, false);
#line 37 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(2326, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2328, 50, false);
#line 37 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                    EndContext();
                    BeginContext(2378, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2380, 50, false);
#line 37 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
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
                BeginContext(2439, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                        }

#line default
#line hidden
                BeginContext(2516, 1182, true);
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
                WriteLiteral("                                  </div>\r\n                                                        </div>\r\n                                                    ");
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
            BeginContext(3705, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3758, 718, true);
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
#line 62 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                             if(tipo == 2)
                                                            {
                                                                

#line default
#line hidden
#line 64 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                 if (Acad != null)
                                                                {

#line default
#line hidden
            BeginContext(4766, 101, true);
            WriteLiteral("                                                                    <th class=\"center\"> Acción</th>\r\n");
            EndContext();
#line 67 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                }

#line default
#line hidden
#line 67 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                 
                                                            }

#line default
#line hidden
            BeginContext(4997, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
#line 69 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                             if(tipo == 1)
                                                            {

#line default
#line hidden
            BeginContext(5136, 97, true);
            WriteLiteral("                                                                <th class=\"center\"> Acción</th>\r\n");
            EndContext();
#line 72 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(5296, 186, true);
            WriteLiteral("                                                        </tr>\r\n                                                    </thead>\r\n                                                    <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(5627, 235, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\r\n                                                                <td hidden></td>\r\n                                                                <td>");
            EndContext();
            BeginContext(5863, 46, false);
#line 80 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.NumPersonal));

#line default
#line hidden
            EndContext();
            BeginContext(5909, 75, true);
            WriteLiteral("</td>\r\n                                                                <td>");
            EndContext();
            BeginContext(5985, 41, false);
#line 81 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(6026, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6028, 50, false);
#line 81 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6078, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6080, 50, false);
#line 81 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6130, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 82 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                 if (tipo == 2)
                                                                {
                                                                    

#line default
#line hidden
#line 84 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                     if (Acad != null)
                                                                    {

#line default
#line hidden
            BeginContext(6444, 184, true);
            WriteLiteral("                                                                        <td class=\"center\">\r\n                                                                            <a data-value=\"");
            EndContext();
            BeginContext(6629, 19, false);
#line 87 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                      Write(item.IdAcadRevistas);

#line default
#line hidden
            EndContext();
            BeginContext(6648, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(6660, 15, false);
#line 87 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                                     Write(item.IdRevistas);

#line default
#line hidden
            EndContext();
            BeginContext(6675, 461, true);
            WriteLiteral(@""" data-controlador=""AcademicosPublicaciones"" data-accion=""EliminarAcadRevistas"" data-regreso=""AcademicosRevistas"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                                <i class=""fa fa-trash-o ""></i>
                                                                            </a>
                                                                        </td>
");
            EndContext();
#line 91 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                    }

#line default
#line hidden
#line 91 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(7274, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
#line 93 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                 if (tipo == 1)
                                                                {

#line default
#line hidden
            BeginContext(7422, 176, true);
            WriteLiteral("                                                                    <td class=\"center\">\r\n                                                                        <a data-value=\"");
            EndContext();
            BeginContext(7599, 19, false);
#line 96 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                  Write(item.IdAcadRevistas);

#line default
#line hidden
            EndContext();
            BeginContext(7618, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(7630, 15, false);
#line 96 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                                                                 Write(item.IdRevistas);

#line default
#line hidden
            EndContext();
            BeginContext(7645, 449, true);
            WriteLiteral(@""" data-controlador=""AcademicosPublicaciones"" data-accion=""EliminarAcadRevistas"" data-regreso=""AcademicosRevistas"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                            <i class=""fa fa-trash-o ""></i>
                                                                        </a>
                                                                    </td>
");
            EndContext();
#line 100 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                                }

#line default
#line hidden
            BeginContext(8161, 67, true);
            WriteLiteral("                                                            </tr>\r\n");
            EndContext();
#line 102 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosPublicaciones\AcademicosRevistas.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(8287, 216, true);
            WriteLiteral("                                                    </tbody>\r\n                                                </table>\r\n                                            </div>\r\n                                            ");
            EndContext();
            BeginContext(8503, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3795068209de13b1c868af7d5d53bef9c7b3c43b28948", async() => {
                BeginContext(8632, 104, true);
                WriteLiteral("\r\n                                                Regresar\r\n                                            ");
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
            BeginContext(8740, 317, true);
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
            BeginContext(9057, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3795068209de13b1c868af7d5d53bef9c7b3c43b31113", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaAcadRevistas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
