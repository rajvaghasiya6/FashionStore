#pragma checksum "F:\FashionStore_\FashionStore_\Views\Home\aboutus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f01151c22cacbc0e670679aadfca14f246ea00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_aboutus), @"mvc.1.0.view", @"/Views/Home/aboutus.cshtml")]
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
#nullable restore
#line 1 "F:\FashionStore_\FashionStore_\Views\_ViewImports.cshtml"
using FashionStore_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FashionStore_\FashionStore_\Views\_ViewImports.cshtml"
using FashionStore_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f01151c22cacbc0e670679aadfca14f246ea00", @"/Views/Home/aboutus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db0821c645ea76f157292aa11459b26b71785b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_aboutus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/aboutus.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "F:\FashionStore_\FashionStore_\Views\Home\aboutus.cshtml"
  
    ViewData["Title"] = "aboutus";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10f01151c22cacbc0e670679aadfca14f246ea003880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://unpkg.com/aos@next/dist/aos.css"" />
<section id=""aboutus"">
    <div class=""jumbotron aboutus1"">
        <h1 class=""heading headingab text-center"" data-aos=""zoom-in"" data-aos-duration=""2000"">About Us</h1>
        <hr class=""w-25 lineab text-white mx-auto pt-5"">
        <div class=""row text-center"">

            <div data-aos=""fade-right"" class="" abdata col-12 col-md-4 col-sm-12 col-lg-4"">
                <div>
                    <h3>Our Mission</h3>
                    <p>To provide our customers a truly international online shopping experience, we guarantee superior quality and craftsmanship through our range, supported by swift and secure processes right from purchase to product delivery and beyond.</p>
                </div>
            </div>
            <div data-aos=""zoom-in"" class="" abdata col-12 col-md-4 col-sm-12 col-lg-4"">
                <div>
                    <h3>Who We Are</h3>
                    <p>The journey of Fashion Store began in t");
            WriteLiteral(@"he year 2000 with the opening of our first wholesale and retail outlet in Surat, India. After the success of this store, Fashion Store launched its online store in 2003, never looking back since then. Today, it is the world's preferred choice for Indian Ethnic Fashion and sets new standards of customer delight every day.</p>
                </div>
            </div>
            <div data-aos=""fade-left"" class="" abdata col-12 col-md-4 col-sm-12 col-lg-4"">
                <div>
                    <h3>Our Vision</h3>
                    <p>We envisage ourselves as the best online shopping experience for customers worldwide, providing rich Indian artistry through truly international fashion statements. The aim is to source the best of Indian Ethnic Fashion and spread its magic.</p>
                </div>
            </div>
        </div>
    </div>
</section>
<script src=""https://unpkg.com/aos@next/dist/aos.js""></script>
<script>
      AOS.init({
        duration:1200
      });
</script>");
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