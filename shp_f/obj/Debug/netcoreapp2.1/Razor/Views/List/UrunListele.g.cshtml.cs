#pragma checksum "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c13784001bff863435a5e119fc148c1fdee4df5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_UrunListele), @"mvc.1.0.view", @"/Views/List/UrunListele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/UrunListele.cshtml", typeof(AspNetCore.Views_List_UrunListele))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c13784001bff863435a5e119fc148c1fdee4df5", @"/Views/List/UrunListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af66cb882effd2edaf823ade9dd67e235f2746d", @"/Views/_ViewImports.cshtml")]
    public class Views_List_UrunListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
  
    ViewData["Title"] = "UrunListele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(121, 194, true);
            WriteLiteral("    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n<h2>Ürünlerimiz</h2>\r\n<table class=\"table table-responsive\">\r\n    <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(367, 78, true);
            WriteLiteral("            <tr>\r\n                <td> <img style=\"width=120px\" height=\"120px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 445, "\"", 470, 1);
#line 15 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
WriteAttributeValue("", 451, product.ProductUrl, 451, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(471, 110, true);
            WriteLiteral("></td>\r\n                <td>\r\n                    <div>\r\n                        <p style=\"font-size:x-large\">");
            EndContext();
            BeginContext(582, 19, false);
#line 18 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
                                                Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(601, 69, true);
            WriteLiteral("</p>\r\n                        <p style=\"font-size:large\">Fiyatı:     ");
            EndContext();
            BeginContext(671, 20, false);
#line 19 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
                                                          Write(product.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(691, 254, true);
            WriteLiteral(" ₺  </p>\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <div>\r\n                        <button class=\"btn btn-success\"> Sepete Ekle <i class=\"fa fa-car\"></i> </button><br /><br />\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 945, "\"", 1020, 1);
#line 25 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
WriteAttributeValue("", 952, Url.Action("UrunIncele","List",new {ProductID =product.ProductId }), 952, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 111, true);
            WriteLiteral(" class=\"btn btn-primary\"> İncele </a>\r\n                    </div>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\tiqdesign\source\repos\shp_f\shp_f\Views\List\UrunListele.cshtml"
        }

#line default
#line hidden
            BeginContext(1143, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
