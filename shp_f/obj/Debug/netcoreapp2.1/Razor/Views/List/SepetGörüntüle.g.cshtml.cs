#pragma checksum "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d664aec1a57a5bc8eebc21518e638c73a6b8142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_SepetGörüntüle), @"mvc.1.0.view", @"/Views/List/SepetGörüntüle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/SepetGörüntüle.cshtml", typeof(AspNetCore.Views_List_SepetGörüntüle))]
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
#line 1 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\_ViewImports.cshtml"
using shp_f;

#line default
#line hidden
#line 2 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\_ViewImports.cshtml"
using shp_f.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d664aec1a57a5bc8eebc21518e638c73a6b8142", @"/Views/List/SepetGörüntüle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af66cb882effd2edaf823ade9dd67e235f2746d", @"/Views/_ViewImports.cshtml")]
    public class Views_List_SepetGörüntüle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SepetiGuncelle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
  
    ViewData["Title"] = "SepetGörüntüle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(122, 700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88cd94fadd8c41ecac98a5143571eaf2", async() => {
                BeginContext(128, 687, true);
                WriteLiteral(@"
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#done"").click(function (e) {
                e.preventDefault();
                $.ajax({
                    url: '/List/SepetiOnayla',
                    success: function () {
                        alert("" Alışverişiniz Tamamlanmıştır. Teşekkür Ederiz."");
                        window.location = '/Home/HomePage';
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 151, true);
            WriteLiteral("\r\n\r\n<style>\r\n    th, td {\r\n        text-align: center\r\n    }\r\n\r\n    input[type=number] {\r\n        width: 50px;\r\n    }\r\n</style>\r\n\r\n<h2>Sepetiniz</h2>\r\n");
            EndContext();
#line 40 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(1000, 74, true);
            WriteLiteral("    <h1 style=\"text-align:center\">Sepetinizde ürün bulunmamaktadır!</h1>\r\n");
            EndContext();
#line 43 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1086, 261, true);
            WriteLiteral(@"    <table class=""table table-responsive"">
        <tbody>
            <tr>
                <th> Ürün No</th>
                <th> Ürün Adı</th>
                <th> Fiyat</th>
                <th style=""text-align:start""> Miktar</th>
            </tr>
");
            EndContext();
#line 54 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
            BeginContext(1407, 135, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div>\r\n                            <p style=\"font-size:large\"> ");
            EndContext();
            BeginContext(1543, 17, false);
#line 59 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
                                                   Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 209, true);
            WriteLiteral(" </p>\r\n                        </div>\r\n                    </td>\r\n                    <td></td>\r\n                    <td>\r\n                        <div>\r\n                            <p style=\"font-size:large\">");
            EndContext();
            BeginContext(1770, 20, false);
#line 65 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
                                                  Write(product.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 142, true);
            WriteLiteral(" ₺</p>\r\n                        </div>\r\n                    </td>\r\n                    <td style=\"text-align:start\">\r\n                        ");
            EndContext();
            BeginContext(1932, 618, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dcd60fd98154c2286d151cf505ad3e9", async() => {
                BeginContext(2002, 85, true);
                WriteLiteral("\r\n                            <input type=\"number\" min=\"1\" name=\"amount\" width=\"10px\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2087, "\"", 2117, 1);
#line 70 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
WriteAttributeValue("", 2095, product.ProductAmount, 2095, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2118, 52, true);
                WriteLiteral(">\r\n                            <button type=\"submit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2170, "\"", 2196, 1);
#line 71 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
WriteAttributeValue("", 2178, product.ProductId, 2178, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2197, 112, true);
                WriteLiteral(" name=\"ProductID\" class=\"btn btn-primary\"><i class=\"fa fa-refresh\"></i></button>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2309, "\"", 2388, 1);
#line 72 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
WriteAttributeValue("", 2316, Url.Action("SepettenKaldir","List",new {ProductID =product.ProductId }), 2316, 72, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2389, "\"", 2412, 1);
#line 72 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
WriteAttributeValue("", 2394, product.ProductId, 2394, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2413, 75, true);
                WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-minus\"></i><p id=\"hiddenid\" hidden>");
                EndContext();
                BeginContext(2489, 17, false);
#line 72 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
                                                                                                                                                                                                            Write(product.ProductId);

#line default
#line hidden
                EndContext();
                BeginContext(2506, 37, true);
                WriteLiteral("</p> </a>\r\n\r\n                        ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2550, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 77 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
            }

#line default
#line hidden
            BeginContext(2617, 137, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n    <div class=\"navbar navbar-right\" style=\"text-align:center\">\r\n        <p class=\"h4\"> Toplam Tutar:  ");
            EndContext();
            BeginContext(2755, 24, false);
#line 82 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
                                 Write(ViewData["Toplam Tutar"]);

#line default
#line hidden
            EndContext();
            BeginContext(2779, 19, true);
            WriteLiteral(" ₺ </p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2798, "\"", 2839, 1);
#line 83 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"
WriteAttributeValue("", 2805, Url.Action("SepetiOnayla","List"), 2805, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2840, 74, true);
            WriteLiteral(" class=\"btn btn-success\" id=\"done\"> Alışverişi Tamamla! </a>\r\n    </div>\r\n");
            EndContext();
#line 85 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\SepetGörüntüle.cshtml"



}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
