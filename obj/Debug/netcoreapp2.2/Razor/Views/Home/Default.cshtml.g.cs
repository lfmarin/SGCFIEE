#pragma checksum "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/Home/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4f71de932270840b2b7647820810fdf809763a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Default), @"mvc.1.0.view", @"/Views/Home/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Default.cshtml", typeof(AspNetCore.Views_Home_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4f71de932270840b2b7647820810fdf809763a", @"/Views/Home/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf9784a52ff93f593cd66162fa38b59d495150e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive padding"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/mac/Desktop/SGCFIEE_ACADEMICOS/SGCFIEE/Views/Home/Default.cshtml"
  

    ViewData["Title"] = "Default";
    Layout = "~/Views/Home/Principal.cshtml";

#line default
#line hidden
            BeginContext(87, 967, true);
            WriteLiteral(@"<!DOCTYPE html>
<html>
    <div class=""row"">
        <div class=""card card-box"">
            <div class=""card-head"">
                <header>Sistema Gestor de la Calidad de la Facultad de Ingenieria Electrica y Electronica</header>
                <div class=""tools"">
                    <a class=""fa fa-repeat btn-color box-refresh"" href=""javascript:;""></a>
	                <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
	                <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                </div>
            </div>
            <div class=""card-body "" id=""bar-parent1"">
                <div class=""row"">
                    <div class=""col-md-9 col-sm-9 col-9"">
                        <div class=""tab-content"">
                            <div class=""tab-pane active show"" id=""tab_7_1"">
                                <div class=""blogThumb"">
                                    <div class=""thumb-center"">");
            EndContext();
            BeginContext(1054, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c4f71de932270840b2b7647820810fdf809763a5385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1132, 1840, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane fade "" id=""tab_7_2"" style=""text-align: justify"">
                                <p>El Sistema de Gestión de la Calidad de la FIEE, es el conjunto de procesos debidamente articulados para gestionar y promover la mejora continua y la calidad en todas las funciones sustantivas de la Facultad de Ingeniería Eléctrica y Electrónica.</p>
                            </div>
                            <div class=""tab-pane fade"" id=""tab_7_3"" style=""text-align: justify"">
                                <p>Promover la sistematización, estandarización y certificación de las funciones sustantivas de la FIEE, con el propósito de contribuir al aseguramiento de la calidad y la mejora continua de los servicios, especialmente en lo que se refiere a la Formación académica y de investigación.</p>
                            </div>
                        </div>
   ");
            WriteLiteral(@"                 </div>
                    <div class=""col-md-3 col-sm-3 col-3"">
                        <ul class=""nav nav-tabs tabs-right"">
                            <li class=""nav-item"">
                                <a href=""#tab_7_1"" data-toggle=""tab"" class=""active show""> SGCFIEE </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#tab_7_2"" data-toggle=""tab"" class=""""> Inicio </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#tab_7_3"" data-toggle=""tab"" class=""""> Objetivos </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</html>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
