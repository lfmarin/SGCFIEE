#pragma checksum "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db0dc3a22f794ffeab6165fac05d0892c24c2d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstudiantesPafis_Index), @"mvc.1.0.view", @"/Views/EstudiantesPafis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstudiantesPafis/Index.cshtml", typeof(AspNetCore.Views_EstudiantesPafis_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0dc3a22f794ffeab6165fac05d0892c24c2d2e", @"/Views/EstudiantesPafis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudiantesPafis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaPafi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/table/table_data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EstudiantesPafis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SolicitudPafi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetallesPafi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs infoextra"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Toda la información"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inscribir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Enlistar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Desenlistar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Desenlistar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var x = (int)ViewData["tipo"];
    Layout = "~/Views/Home/Principal.cshtml";

#line default
#line hidden
            BeginContext(171, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(175, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0dc3a22f794ffeab6165fac05d0892c24c2d2e8113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 795, true);
            WriteLiteral(@"
<!DOCTYPE html>

<html>
<div class=""profile-content"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card card-topline-green"">
                <div class=""card-head"">
                    <header>Pafis</header>
                    <div class=""tools"">
                        <a class=""fa fa-repeat btn-color box-refresh"" href=""javascript:;""></a>
                        <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
                        <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                    </div>
                </div>
            
            <div class=""card-body"">
                <div class=""row p-b-20"">
                    <div class=""col-md-6 col-sm-6 col-6"">
");
            EndContext();
#line 27 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                         if (x == 3)
                        {

#line default
#line hidden
            BeginContext(1096, 85, true);
            WriteLiteral("                            <div class=\"btn-group\">\r\n                                ");
            EndContext();
            BeginContext(1181, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0dc3a22f794ffeab6165fac05d0892c24c2d2e10496", async() => {
                BeginContext(1283, 86, true);
                WriteLiteral("\r\n                                    Solicitar pafi\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(1373, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 34 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1438, 888, true);
            WriteLiteral(@"                    </div>
                </div>
                <table class=""table table-striped table-bordered table-hover table-checkable order-column"" style=""width: 100%"" id=""example1"">
                    <thead>
                        <tr>
                            <th class=""center"" hidden></th>
                            <th class=""center"">Alumnos inscritos</th>
                            <th class=""center"">Nombre del pafi</th>
                            <th class=""center"">Horario</th>
                            <th class=""center"">Nombre del academico</th>
                            <th class=""center"">Salon</th>
                            <th class=""center"">Programa educativo al que impacta</th>
                            <th class=""center"">Acción</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 52 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2407, 169, true);
            WriteLiteral("                            <tr class=\"odd gradeX\">\r\n                                <td class=\"center\" hidden></td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2577, 44, false);
#line 56 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.TotalAlum));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2680, 45, false);
#line 57 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.NombrePafi));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2784, 42, false);
#line 58 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Horario));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2885, 48, false);
#line 59 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.NombreMaestro));

#line default
#line hidden
            EndContext();
            BeginContext(2933, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(2992, 43, false);
#line 60 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.ClvSalon));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 58, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">");
            EndContext();
            BeginContext(3094, 45, false);
#line 61 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.ProgrmaEdu));

#line default
#line hidden
            EndContext();
            BeginContext(3139, 98, true);
            WriteLiteral("</td>\r\n                                <td class=\"center\">\r\n                                    \r\n");
            EndContext();
#line 64 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                     if (x == 1)
                                    {

#line default
#line hidden
            BeginContext(3326, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(3366, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0dc3a22f794ffeab6165fac05d0892c24c2d2e17091", async() => {
                BeginContext(3526, 115, true);
                WriteLiteral("\r\n                                            <i class=\"fa fa-check\"></i>\r\n                                        ");
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
#line 66 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                             WriteLiteral(item.idPafi);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(3645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 69 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                        
                                    }

#line default
#line hidden
            BeginContext(3728, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 71 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                     if (x == 3)
                                    {
                                        

#line default
#line hidden
#line 73 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                         if (item.ocupado == 0)
                                        {

#line default
#line hidden
            BeginContext(3925, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3969, 275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0dc3a22f794ffeab6165fac05d0892c24c2d2e20899", async() => {
                BeginContext(4114, 126, true);
                WriteLiteral("\r\n                                                <i class=\"fa fa-sign-in \"></i>\r\n                                            ");
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
#line 75 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                                 WriteLiteral(item.idPafi);

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
            BeginContext(4244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 78 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                        }

#line default
#line hidden
#line 79 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                         if (item.ocupado == 1)
                                        {

#line default
#line hidden
            BeginContext(4397, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4441, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0dc3a22f794ffeab6165fac05d0892c24c2d2e24291", async() => {
                BeginContext(4590, 127, true);
                WriteLiteral("\r\n                                                <i class=\"fa fa-sign-out \"></i>\r\n                                            ");
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
#line 81 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                                 WriteLiteral(item.idPafi);

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4721, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                        }

#line default
#line hidden
#line 84 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(4805, 74, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 88 "C:\Users\dxvm1\Desktop\sgc cuarentena\SGCFIEE\Views\EstudiantesPafis\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4906, 139, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGCFIEE.Models.TablaPafi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
