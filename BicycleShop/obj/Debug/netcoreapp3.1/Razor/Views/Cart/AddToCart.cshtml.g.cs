#pragma checksum "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4070659f294e43178c6cdf1dda50113d855565d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_AddToCart), @"mvc.1.0.view", @"/Views/Cart/AddToCart.cshtml")]
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
#line 1 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\_ViewImports.cshtml"
using BicycleShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\_ViewImports.cshtml"
using BicycleShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4070659f294e43178c6cdf1dda50113d855565d0", @"/Views/Cart/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9b643b71e7ceb182674a1854f50de7d141e073", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BicycleShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"d-flex justify-content-center align-items-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4070659f294e43178c6cdf1dda50113d855565d04537", async() => {
                WriteLiteral("\r\n        <div class=\"input-group mt-3\">\r\n            <span class=\"input-group-text form-control\" id=\"inputGroup-sizing-default\">");
#nullable restore
#line 8 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml"
                                                                                  Write(Model.Bicycle.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <span class=\"input-group-text\" id=\"inputGroup-sizing-default\">");
#nullable restore
#line 9 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml"
                                                                     Write(Model.Bicycle.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 435, "\"", 460, 1);
#nullable restore
#line 10 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml"
WriteAttributeValue("", 443, Model.Bicycle.Id, 443, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"input-group mt-3\">\r\n            <span class=\"input-group-text\" id=\"inputGroup-sizing-default\">Your lastname:</span>\r\n            <input type=\"text\" class=\"form-control\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 686, "\"", 709, 1);
#nullable restore
#line 14 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml"
WriteAttributeValue("", 694, Model.Quantity, 694, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Ivanov\" aria-label=\"Sizing example input\" aria-describedby=\"inputGroup-sizing-default\">\r\n        </div>\r\n        ");
#nullable restore
#line 16 "B:\Програмирувание\Шаг\ASPNET\MVC\Homeworks\BicycleShop\BicycleShop\Views\Cart\AddToCart.cshtml"
   Write(Html.ValidationMessage("Quantity"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"d-flex justify-content-between mt-3\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4070659f294e43178c6cdf1dda50113d855565d07213", async() => {
                    WriteLiteral("Back");
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
                WriteLiteral("\r\n            <button class=\"btn btn-outline-success px-5\" type=\"submit\">Enter</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BicycleShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
