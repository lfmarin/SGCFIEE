#pragma checksum "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b9dcf7df1330e295b284cedefd46868fdaded2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosComisiones_AcademicosJurExperiencia), @"mvc.1.0.view", @"/Views/AcademicosComisiones/AcademicosJurExperiencia.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosComisiones/AcademicosJurExperiencia.cshtml", typeof(AspNetCore.Views_AcademicosComisiones_AcademicosJurExperiencia))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b9dcf7df1330e295b284cedefd46868fdaded2", @"/Views/AcademicosComisiones/AcademicosJurExperiencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosComisiones_AcademicosJurExperiencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaAcadJurExperiencia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosComisiones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarAcadJurExperiencia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexJurExperiencia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
  
    ViewData["Title"] = "AcadArticulos";
    Layout = "~/Views/Home/Principal.cshtml";
    var acade = (IEnumerable<Academicos>)ViewData["academicos"];
    var Acad = (Academicosjuradorecep)ViewData["Acad"];
    var tipo = (int)ViewData["tipo"];

#line default
#line hidden
            BeginContext(320, 714, true);
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
#line 26 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                 if (Acad != null || tipo == 1)
                                                {

#line default
#line hidden
            BeginContext(1166, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(1218, 2539, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40b9dcf7df1330e295b284cedefd46868fdaded28278", async() => {
                BeginContext(1345, 78, true);
                WriteLiteral("\r\n                                                        <input name=\"jurado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1423, "\"", 1449, 1);
#line 29 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
WriteAttributeValue("", 1431, ViewData["idJur"], 1431, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1450, 598, true);
                WriteLiteral(@" type=""hidden""/>
                                                        <input name=""Lider"" value=""0"" type=""hidden""/>
                                                        <div class=""row p-b-20"">
                                                            <div class=""col-md-4 col-md-4"">
                                                                <div class=""form-group"">
                                                                    <label>Académico</label>
                                                                    <select name=""idAcademico"" class=""form-control"">
");
                EndContext();
#line 36 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                         foreach (var item in acade)
                                                                        {

#line default
#line hidden
                BeginContext(2225, 76, true);
                WriteLiteral("                                                                            ");
                EndContext();
                BeginContext(2301, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40b9dcf7df1330e295b284cedefd46868fdaded210321", async() => {
                    BeginContext(2337, 41, false);
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                    EndContext();
                    BeginContext(2378, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2380, 50, false);
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                    EndContext();
                    BeginContext(2430, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(2432, 50, false);
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
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
                BeginContext(2491, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                        }

#line default
#line hidden
                BeginContext(2568, 1182, true);
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
            BeginContext(3757, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3810, 718, true);
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
#line 63 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                             if(tipo == 2)
                                                            {
                                                                

#line default
#line hidden
#line 65 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                 if (Acad != null)
                                                                {

#line default
#line hidden
            BeginContext(4818, 101, true);
            WriteLiteral("                                                                    <th class=\"center\"> Acción</th>\r\n");
            EndContext();
#line 68 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                }

#line default
#line hidden
#line 68 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                 
                                                            }

#line default
#line hidden
            BeginContext(5049, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
#line 70 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                             if(tipo == 1)
                                                            {

#line default
#line hidden
            BeginContext(5188, 97, true);
            WriteLiteral("                                                                <th class=\"center\"> Acción</th>\r\n");
            EndContext();
#line 73 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(5348, 186, true);
            WriteLiteral("                                                        </tr>\r\n                                                    </thead>\r\n                                                    <tbody>\r\n");
            EndContext();
#line 77 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                         foreach (var item in Model)
                                                        {

#line default
#line hidden
            BeginContext(5679, 235, true);
            WriteLiteral("                                                            <tr class=\"odd gradeX\">\r\n                                                                <td hidden></td>\r\n                                                                <td>");
            EndContext();
            BeginContext(5915, 46, false);
#line 81 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.NumPersonal));

#line default
#line hidden
            EndContext();
            BeginContext(5961, 75, true);
            WriteLiteral("</td>\r\n                                                                <td>");
            EndContext();
            BeginContext(6037, 41, false);
#line 82 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(6078, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6080, 50, false);
#line 82 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6130, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6132, 50, false);
#line 82 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                                                                              Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(6182, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 83 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                 if (tipo == 2)
                                                                {
                                                                    

#line default
#line hidden
#line 85 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                     if (Acad != null)
                                                                    {

#line default
#line hidden
            BeginContext(6496, 184, true);
            WriteLiteral("                                                                        <td class=\"center\">\r\n                                                                            <a data-value=\"");
            EndContext();
            BeginContext(6681, 17, false);
#line 88 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                      Write(item.IdAcadJurExp);

#line default
#line hidden
            EndContext();
            BeginContext(6698, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(6710, 13, false);
#line 88 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                                   Write(item.idJurado);

#line default
#line hidden
            EndContext();
            BeginContext(6723, 470, true);
            WriteLiteral(@""" data-controlador=""AcademicosComisiones"" data-accion=""EliminarAcadJurExperiencia"" data-regreso=""AcademicosJurExperiencia"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                                <i class=""fa fa-trash-o ""></i>
                                                                            </a>
                                                                        </td>
");
            EndContext();
#line 92 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                    }

#line default
#line hidden
#line 92 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                     
                                                                }

#line default
#line hidden
            BeginContext(7331, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
#line 94 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                 if (tipo == 1)
                                                                {

#line default
#line hidden
            BeginContext(7479, 176, true);
            WriteLiteral("                                                                    <td class=\"center\">\r\n                                                                        <a data-value=\"");
            EndContext();
            BeginContext(7656, 17, false);
#line 97 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                  Write(item.IdAcadJurExp);

#line default
#line hidden
            EndContext();
            BeginContext(7673, 11, true);
            WriteLiteral("\" data-id=\"");
            EndContext();
            BeginContext(7685, 13, false);
#line 97 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                                                               Write(item.idJurado);

#line default
#line hidden
            EndContext();
            BeginContext(7698, 458, true);
            WriteLiteral(@""" data-controlador=""AcademicosComisiones"" data-accion=""EliminarAcadJurExperiencia"" data-regreso=""AcademicosJurExperiencia"" name=""eliminaracademico"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                                                            <i class=""fa fa-trash-o ""></i>
                                                                        </a>
                                                                    </td>
");
            EndContext();
#line 101 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                                }

#line default
#line hidden
            BeginContext(8223, 67, true);
            WriteLiteral("                                                            </tr>\r\n");
            EndContext();
#line 103 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosComisiones\AcademicosJurExperiencia.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(8349, 216, true);
            WriteLiteral("                                                    </tbody>\r\n                                                </table>\r\n                                            </div>\r\n                                            ");
            EndContext();
            BeginContext(8565, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40b9dcf7df1330e295b284cedefd46868fdaded229129", async() => {
                BeginContext(8697, 104, true);
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
            BeginContext(8805, 317, true);
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
            BeginContext(9122, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40b9dcf7df1330e295b284cedefd46868fdaded231294", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaAcadJurExperiencia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
