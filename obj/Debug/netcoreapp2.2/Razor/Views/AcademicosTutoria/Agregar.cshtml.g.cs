#pragma checksum "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39220c14a015ee228238eb0b4bca09493d04c262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosTutoria_Agregar), @"mvc.1.0.view", @"/Views/AcademicosTutoria/Agregar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosTutoria/Agregar.cshtml", typeof(AspNetCore.Views_AcademicosTutoria_Agregar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39220c14a015ee228238eb0b4bca09493d04c262", @"/Views/AcademicosTutoria/Agregar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosTutoria_Agregar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCFIEE.Models.ptutorados>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("academico"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Tipotutorado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("checked", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("alumno"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("nombre_A"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingresar..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("matricula_A"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosTutoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Guardar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
  
    ViewData["Title"] = "Agregar";
    Layout = "~/Views/Home/Principal.cshtml";
    var acad = (IEnumerable<Academicos>)ViewData["academicos"];
    var alum = (IEnumerable<pAcademicosAlumnos>)ViewData["alumnos"];
    int tipo = (int)ViewData["tipo"];

#line default
#line hidden
            BeginContext(298, 322, true);
            WriteLiteral(@"
<!DOCTYPE html>
<html lang=""en"">
<div class=""row"">
    <div class=""col-md-12 col-sm-12"">
        <div class=""card card-box"">
            <div class=""card-topline-green card-head"">
                <header>TUTORADO</header>
            </div>
            <div class=""card-body "" id=""bar-parent2"">
                ");
            EndContext();
            BeginContext(620, 3165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26210210", async() => {
                BeginContext(670, 98, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6 col-md-6\">\r\n");
                EndContext();
#line 22 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                             if (tipo == 1)
                            {

#line default
#line hidden
                BeginContext(844, 156, true);
                WriteLiteral("                                <div class=\"form-group\">\r\n                                    <label>Académico</label>\r\n                                    ");
                EndContext();
                BeginContext(1000, 505, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26211178", async() => {
                    BeginContext(1067, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 27 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                         foreach (var item in acad)
                                        {

#line default
#line hidden
                    BeginContext(1181, 44, true);
                    WriteLiteral("                                            ");
                    EndContext();
                    BeginContext(1225, 190, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26211994", async() => {
                        BeginContext(1261, 41, false);
#line 29 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                        EndContext();
                        BeginContext(1302, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1304, 50, false);
#line 29 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                                                                     Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
                        EndContext();
                        BeginContext(1354, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(1356, 50, false);
#line 29 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                                                                                                                         Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 29 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
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
                    BeginContext(1415, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 30 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                        }

#line default
#line hidden
                    BeginContext(1460, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 26 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAcademicos);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1505, 42, true);
                WriteLiteral("\r\n                                </div>\r\n");
                EndContext();
#line 33 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                            }

#line default
#line hidden
                BeginContext(1578, 134, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                Miembro <br>\r\n                                ");
                EndContext();
                BeginContext(1712, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39220c14a015ee228238eb0b4bca09493d04c26217658", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipotutorado);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1796, 61, true);
                WriteLiteral(" Alumno de la facultad <br>\r\n                                ");
                EndContext();
                BeginContext(1857, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39220c14a015ee228238eb0b4bca09493d04c26220052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipotutorado);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1930, 313, true);
                WriteLiteral(@" Alumno externo de la facultad
                            </div>
                        </div>
                        <div class=""col-md-6 col-md-6"">
                            <div class=""form-group"" id=""A_interno"">
                                <label>Alumno</label>
                                ");
                EndContext();
                BeginContext(2243, 463, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26222618", async() => {
                    BeginContext(2303, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 45 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                     foreach (var item in alum)
                                    {

#line default
#line hidden
                    BeginContext(2409, 40, true);
                    WriteLiteral("                                        ");
                    EndContext();
                    BeginContext(2449, 175, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26223422", async() => {
                        BeginContext(2482, 41, false);
#line 47 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
                        EndContext();
                        BeginContext(2523, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2525, 44, false);
#line 47 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                                                              Write(Html.DisplayFor(modelItem => item.A_paterno));

#line default
#line hidden
                        EndContext();
                        BeginContext(2569, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2571, 44, false);
#line 47 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                                                                                                                                            Write(Html.DisplayFor(modelItem => item.A_materno));

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 47 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                           WriteLiteral(item.IdAlumnos);

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
                    BeginContext(2624, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 48 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
                                    }

#line default
#line hidden
                    BeginContext(2665, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 44 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAlumno);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2706, 202, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\" id=\"nombre\">\r\n                                <label>Nombre del alumno</label>\r\n                                ");
                EndContext();
                BeginContext(2908, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39220c14a015ee228238eb0b4bca09493d04c26228782", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 53 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nombre);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3005, 197, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\" id=\"matricula\">\r\n                                <label>Matricula</label>\r\n                                ");
                EndContext();
                BeginContext(3202, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39220c14a015ee228238eb0b4bca09493d04c26231078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#line 57 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Matricula);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3305, 204, true);
                WriteLiteral("\r\n                            </div>\r\n                            <input id=\"guardar\" type=\"submit\" value=\"Guardar\" class=\"btn btn-success btn-sm m-b-10\" style=\"float:right\">\r\n                            ");
                EndContext();
                BeginContext(3509, 191, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39220c14a015ee228238eb0b4bca09493d04c26233389", async() => {
                    BeginContext(3624, 72, true);
                    WriteLiteral("\r\n                                Cancelar\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3700, 78, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
#line 19 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\AcademicosTutoria\Agregar.cshtml"
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
            BeginContext(3785, 67, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCFIEE.Models.ptutorados> Html { get; private set; }
    }
}
#pragma warning restore 1591
