#pragma checksum "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5266296248a114b90b826ee58b0b33b35a7ea0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosTutoria_Index), @"mvc.1.0.view", @"/Views/AcademicosTutoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosTutoria/Index.cshtml", typeof(AspNetCore.Views_AcademicosTutoria_Index))]
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
#line 1 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE;

#line default
#line hidden
#line 2 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\_ViewImports.cshtml"
using SGCFIEE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5266296248a114b90b826ee58b0b33b35a7ea0", @"/Views/AcademicosTutoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosTutoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCFIEE.Models.Academicos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("agregar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosTutoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("academicos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IdIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Home/Principal.cshtml";
    var aca = (IEnumerable<Academicos>)ViewData["academicos"];
    var tutoI = (IEnumerable<pAcademicosAlumnos>)ViewData["tutoI"];
    var tutoE = (IEnumerable<TutoradosExternos>)ViewData["tutoE"];

#line default
#line hidden
            BeginContext(324, 786, true);
            WriteLiteral(@"
<!DOCTYPE html>
<html lang=""en"">
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-topline-green"">
            <div class=""card-head"">
                <header>TUTORADOS</header>
                <div class=""tools"">
                    <a class=""fa fa-repeat btn-color box-refresh"" href=""javascript:;""></a>
                    <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
                    <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                </div>
            </div>
            <div class=""card-body "">
                <div class=""row p-b-20"">
                    <div class=""col-md-6 col-sm-6 col-6"">
                        <div class=""btn-group"">
                            ");
            EndContext();
            BeginContext(1110, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea09004", async() => {
                BeginContext(1220, 118, true);
                WriteLiteral("\r\n                                Agregar <i class=\"fa fa-plus\" style=\"color:white\"></i>\r\n                            ");
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
            BeginContext(1342, 157, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
            EndContext();
            BeginContext(1499, 988, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea011038", async() => {
                BeginContext(1549, 172, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            \r\n                                <label>Académico</label>\r\n                                ");
                EndContext();
                BeginContext(1721, 485, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea011603", async() => {
                    BeginContext(1789, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 39 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                     foreach (var item in aca)
                                    {

#line default
#line hidden
                    BeginContext(1894, 40, true);
                    WriteLiteral("                                        ");
                    EndContext();
                    BeginContext(1934, 190, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea012397", async() => {
                        BeginContext(1970, 41, false);
#line 41 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                        EndContext();
                        BeginContext(2011, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2013, 50, false);
#line 41 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                                                                                                 Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                        EndContext();
                        BeginContext(2063, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2065, 50, false);
#line 41 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                                                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 41 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
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
                    BeginContext(2124, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 42 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                    }

#line default
#line hidden
                    BeginContext(2165, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 38 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAcademicos);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2206, 274, true);
                WriteLiteral(@"
                            <br />
                            <button id=""BuscarMov"" type=""submit"" class=""btn btn-success btn-sm m-b-10"">
                                Buscar
                            </button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 34 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2487, 584, true);
            WriteLiteral(@"
                </div>
                <table class=""table table-striped table-bordered table-hover table-checkable order-column"" style=""width: 100%"" id=""tabla_tutoria"">
                    <thead>
                        <tr>
                            <th class=""center""> Matricula </th>
                            <th class=""center""> Nombre del alumno</th>
                            <th class=""center""> Miembro </th>
                            <th class=""center""> Acción</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 61 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                         foreach (var item in tutoI)
                        {

#line default
#line hidden
            BeginContext(3152, 89, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td>");
            EndContext();
            BeginContext(3242, 44, false);
#line 64 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.matricula));

#line default
#line hidden
            EndContext();
            BeginContext(3286, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3330, 41, false);
#line 65 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(3371, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3373, 44, false);
#line 65 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.A_paterno));

#line default
#line hidden
            EndContext();
            BeginContext(3417, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3419, 44, false);
#line 65 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.A_materno));

#line default
#line hidden
            EndContext();
            BeginContext(3463, 146, true);
            WriteLiteral("</td>\r\n                                <td>Interno</td>\r\n                                <td class=\"center\">\r\n                                    ");
            EndContext();
            BeginContext(3609, 248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea022318", async() => {
                BeginContext(3745, 108, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-pencil\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                         WriteLiteral(item.IdAlumnos);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3857, 53, true);
            WriteLiteral("\r\n                                    <a data-value=\"");
            EndContext();
            BeginContext(3911, 14, false);
#line 71 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                              Write(item.IdAlumnos);

#line default
#line hidden
            EndContext();
            BeginContext(3925, 341, true);
            WriteLiteral(@""" data-controlador=""AcademicosTutoria"" data-accion=""EliminarI"" data-regreso=""Index"" name=""eliminardato"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                        <i class=""fa fa-trash-o ""></i>
                                    </a>
                                </td>
                            </tr>
");
            EndContext();
#line 76 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4293, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 77 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                         foreach (var item in tutoE)
                        {

#line default
#line hidden
            BeginContext(4374, 89, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td>");
            EndContext();
            BeginContext(4464, 44, false);
#line 80 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(4508, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4552, 41, false);
#line 81 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(4593, 146, true);
            WriteLiteral("</td>\r\n                                <td>Externo</td>\r\n                                <td class=\"center\">\r\n                                    ");
            EndContext();
            BeginContext(4739, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5266296248a114b90b826ee58b0b33b35a7ea027521", async() => {
                BeginContext(4886, 108, true);
                WriteLiteral("\r\n                                        <i class=\"fa fa-pencil\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                         WriteLiteral(item.IdTutoradosExternos);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4998, 53, true);
            WriteLiteral("\r\n                                    <a data-value=\"");
            EndContext();
            BeginContext(5052, 24, false);
#line 87 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                                              Write(item.IdTutoradosExternos);

#line default
#line hidden
            EndContext();
            BeginContext(5076, 341, true);
            WriteLiteral(@""" data-controlador=""AcademicosTutoria"" data-accion=""EliminarE"" data-regreso=""Index"" name=""eliminardato"" class=""btn btn-danger btn-xs"" title=""Eliminar"">
                                        <i class=""fa fa-trash-o ""></i>
                                    </a>
                                </td>
                            </tr>
");
            EndContext();
#line 92 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosTutoria\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5444, 127, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCFIEE.Models.Academicos> Html { get; private set; }
    }
}
#pragma warning restore 1591
