#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b36"
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
#line 1 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/_ViewImports.cshtml"
using SGCFIEE;

#line default
#line hidden
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/_ViewImports.cshtml"
using SGCFIEE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b36", @"/Views/EstudiantesPafis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudiantesPafis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGCFIEE.Models.TablaPafi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/table/table_data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/sweet-alert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/sweet-alert/sweet-alert-data.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EstudiantesPafis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SolicitudPafi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm m-b-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetallesPafi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs infoextra"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Toda la información"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inscribir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-xs eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Enlistar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Desenlistar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Desenlistar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
  
    ViewData["Title"] = "Index";
    var x = (int)ViewData["tipo"];
    Layout = "~/Views/Home/Principal.cshtml";

#line default
#line hidden
            BeginContext(165, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(169, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b368807", async() => {
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
            BeginContext(230, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(231, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b369964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(302, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b3611121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 55, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n<div class=\"profile-content\">\n");
            EndContext();
#line 14 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
     if (TempData["msg"] != null)
    {
        

#line default
#line hidden
            BeginContext(479, 25, false);
#line 16 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
   Write(Html.Raw(TempData["msg"]));

#line default
#line hidden
            EndContext();
#line 16 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                  
    }

#line default
#line hidden
            BeginContext(511, 720, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12 col-sm-12"">
            <div class=""card card-topline-green"">
                <div class=""card-head"">
                    <header>PAFIs</header>
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
#line 33 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                         if (x == 3)
                        {

#line default
#line hidden
            BeginContext(1294, 84, true);
            WriteLiteral("                            <div class=\"btn-group\">\n                                ");
            EndContext();
            BeginContext(1378, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b3614116", async() => {
                BeginContext(1480, 84, true);
                WriteLiteral("\n                                    Solicitar pafi\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
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
            BeginContext(1568, 36, true);
            WriteLiteral("\n                            </div>\n");
            EndContext();
#line 40 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1630, 1028, true);
            WriteLiteral(@"                    </div>
                </div>
                <div class=""table-scrollable"">
                    <table class=""table table-striped table-bordered table-hover table-checkable order-column"" style=""width: 100%"" id=""example1"">
                        <thead>
                            <tr>
                                <th hidden></th>
                                <th class=""center"">Alumnos inscritos</th>
                                <th class=""center"">Nombre del PAFI</th>
                                <th class=""center"">Horario</th>
                                <th class=""center"">Nombre del académico</th>
                                <th class=""center"">Salón</th>
                                <th class=""center"">Programa educativo al que impacta</th>
                                <th class=""center"">Tipo de PAFI</th>
                                <th class=""center"">Acción</th>

                            </tr>
                        </thead>
                        <tbo");
            WriteLiteral("dy>\n");
            EndContext();
#line 60 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2745, 164, true);
            WriteLiteral("                                <tr class=\"odd gradeX\">\n                                    <td hidden></td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(2910, 44, false);
#line 64 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.TotalAlum));

#line default
#line hidden
            EndContext();
            BeginContext(2954, 61, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3016, 45, false);
#line 65 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.NombrePafi));

#line default
#line hidden
            EndContext();
            BeginContext(3061, 61, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3123, 42, false);
#line 66 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Horario));

#line default
#line hidden
            EndContext();
            BeginContext(3165, 61, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3227, 48, false);
#line 67 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.NombreMaestro));

#line default
#line hidden
            EndContext();
            BeginContext(3275, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3277, 45, false);
#line 67 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.ApePaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3322, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3324, 45, false);
#line 67 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                                                                                                                   Write(Html.DisplayFor(modelItem => item.ApeMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3369, 61, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3431, 43, false);
#line 68 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.ClvSalon));

#line default
#line hidden
            EndContext();
            BeginContext(3474, 61, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">");
            EndContext();
            BeginContext(3536, 45, false);
#line 69 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.ProgrmaEdu));

#line default
#line hidden
            EndContext();
            BeginContext(3581, 62, true);
            WriteLiteral("</td>\n                                    <td class=\"center\">\n");
            EndContext();
#line 71 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                     if(item.TipoPafi == 0)
                                    {

#line default
#line hidden
            BeginContext(3741, 63, true);
            WriteLiteral("                                        <div>Nivelatorio</div>\n");
            EndContext();
#line 74 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3921, 60, true);
            WriteLiteral("                                        <div>Remedial</div>\n");
            EndContext();
#line 78 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4019, 98, true);
            WriteLiteral("                                    </td>\n                                    <td class=\"center\">\n");
            EndContext();
#line 81 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                         if (x == 1)
                                        {

#line default
#line hidden
            BeginContext(4212, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(4256, 285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b3622839", async() => {
                BeginContext(4416, 121, true);
                WriteLiteral("\n                                                <i class=\"fa fa-check\"></i>\n                                            ");
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
#line 83 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                 WriteLiteral(item.idPafi);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4541, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 86 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4584, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 87 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                         if (x == 3)
                                        {
                                            

#line default
#line hidden
#line 89 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                             if (item.inscrito == 0)
                                            {

#line default
#line hidden
            BeginContext(4794, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(4842, 281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b3626581", async() => {
                BeginContext(4987, 132, true);
                WriteLiteral("\n                                                    <i class=\"fa fa-sign-in \"></i>\n                                                ");
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
#line 91 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                     WriteLiteral(item.idPafi);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5123, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 94 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                            }

#line default
#line hidden
#line 95 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                             if (item.inscrito == 1)
                                            {

#line default
#line hidden
            BeginContext(5285, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(5333, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc36d1c12edb8b45aa7eca31d2c2e848f4b4b3629945", async() => {
                BeginContext(5482, 133, true);
                WriteLiteral("\n                                                    <i class=\"fa fa-sign-out \"></i>\n                                                ");
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
#line 97 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                                     WriteLiteral(item.idPafi);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5619, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 100 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                            }

#line default
#line hidden
#line 100 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                                             
                                        }

#line default
#line hidden
            BeginContext(5708, 80, true);
            WriteLiteral("                                    </td>\n                                </tr>\n");
            EndContext();
#line 104 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/EstudiantesPafis/Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5818, 161, true);
            WriteLiteral("\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n        </div>\n    </div>\n</div>\n</html>\n");
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
