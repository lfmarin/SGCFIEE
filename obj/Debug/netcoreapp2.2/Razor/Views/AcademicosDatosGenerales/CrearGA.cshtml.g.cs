#pragma checksum "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosDatosGenerales\CrearGA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be65cc4118304b474baab2f8ae798bcc70922d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcademicosDatosGenerales_CrearGA), @"mvc.1.0.view", @"/Views/AcademicosDatosGenerales/CrearGA.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AcademicosDatosGenerales/CrearGA.cshtml", typeof(AspNetCore.Views_AcademicosDatosGenerales_CrearGA))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be65cc4118304b474baab2f8ae798bcc70922d04", @"/Views/AcademicosDatosGenerales/CrearGA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1225633a62ddc17bf9f6645008885b94288a8c6a", @"/Views/_ViewImports.cshtml")]
    public class Views_AcademicosDatosGenerales_CrearGA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGCFIEE.Models.Estudios>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "${nt.idNombre_Titulo}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "${ins.id_I_E}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "${GT.id}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AcademicosDatosGenerales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarGA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dxvm1\Desktop\SGCFIEE\SGCFIEE\Views\AcademicosDatosGenerales\CrearGA.cshtml"
  
    ViewData["Title"] = "Crear";
    Layout = "~/Views/Home/Principal.cshtml";
    var acad = (IEnumerable<Academicos>)ViewData["academicos"];
    var perio = (IEnumerable<TipoPeriodo>)ViewData["periodos"];
    var pe = (IEnumerable<ProgramaEducativo>)ViewData["pe"];
    var salones = (IEnumerable<TbSalones>)ViewData["salones"];

#line default
#line hidden
            BeginContext(377, 245, true);
            WriteLiteral("\r\n<html>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12\">\r\n        <div class=\"card card-box\">\r\n            <div class=\"card-topline-green card-head\">\r\n                <header>Grados académicos</header>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(622, 4430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65cc4118304b474baab2f8ae798bcc70922d046501", async() => {
                BeginContext(737, 465, true);
                WriteLiteral(@"
                <div class=""card-body "" <div class=""row"">
                        <div class=""col-md-6 col-sm-6"">
                            <div class=""form-group"">
                                <label>Nombre del titulo</label>
                                <select id=""titulo_grados"" class=""form-control"" name=""Titulo_grado"">
                                    <c:forEach items=""${requestScope.nt}"" var=""nt"">
                                        ");
                EndContext();
                BeginContext(1202, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65cc4118304b474baab2f8ae798bcc70922d047365", async() => {
                    BeginContext(1240, 12, true);
                    WriteLiteral("${nt.nombre}");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1261, 462, true);
                WriteLiteral(@"
                                    </c:forEach>
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>IES</label>
                                <select id=""ies_grados"" class=""form-control"" name=""Institucion"">
                                    <c:forEach items=""${requestScope.ins}"" var=""ins"">
                                        ");
                EndContext();
                BeginContext(1723, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65cc4118304b474baab2f8ae798bcc70922d049309", async() => {
                    BeginContext(1753, 13, true);
                    WriteLiteral("${ins.nombre}");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1775, 470, true);
                WriteLiteral(@"
                                    </c:forEach>
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Grado obtenido</label>
                                <select id=""grados"" class=""form-control"" name=""Grado_obtenido"">
                                    <c:forEach items=""${requestScope.GT}"" var=""GT"">
                                        ");
                EndContext();
                BeginContext(2245, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65cc4118304b474baab2f8ae798bcc70922d0411262", async() => {
                    BeginContext(2270, 12, true);
                    WriteLiteral("${GT.nombre}");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2291, 2754, true);
                WriteLiteral(@"
                                    </c:forEach>
                                </select>
                            </div>
                            <div class=""form-group"">
                                Fecha de egreso
                                <input id=""fechaegreso"" type=""date"" class=""form-control"" name=""Fechaegreso"">
                                <br>
                            </div>
                        </div>
                        <div class=""col-md-6 col-sm-6"">
                            <div class=""form-group"">
                                Fecha de titulación
                                <input id=""fechatitulacion"" type=""date"" class=""form-control"" name=""FechaTitulacion"">
                                <br>
                            </div>
                            <div class=""form-group"">
                                <label>Reconocimiento:</label><br>
                                <div class=""radio p-0"">
                                    <in");
                WriteLiteral(@"put type=""radio"" name=""reconocimiento"" id=""reconocimiento1"" value=""0"">
                                    <label for=""reconocimiento1"">
                                        Ninguno
                                    </label>
                                    <br>
                                    <input type=""radio"" name=""reconocimiento"" id=""reconocimiento2"" value=""1"">
                                    <label for=""reconocimiento2"">
                                        Acreditado
                                    </label>
                                    <br>
                                    <input type=""radio"" name=""reconocimiento"" id=""reconocimiento3"" value=""2"">
                                    <label for=""reconocimiento3"">
                                        PNPC
                                    </label>
                                </div>
                            </div>
                            <label>Subir titulo</label><br>
                       ");
                WriteLiteral(@"     <input type=""file"" class=""default"" id=""archivotitulo"" name=""Archivotitulo"">
                            <br>
                            <label>Subir cedula</label><br>
                            <input type=""file"" class=""default"" id=""archivocedula"" name=""Archivocedula"">
                            <br>
                            <input id=""guardarreconocimientos"" type=""submit"" value=""Guardar"" class=""btn btn-success btn-sm m-b-10"" style=""float:right"">
                            <br>
                            <br>
                            <br>
                        </div>
                    </div>id=""bar-parent2"">
                    
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5052, 47, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGCFIEE.Models.Estudios> Html { get; private set; }
    }
}
#pragma warning restore 1591
