#pragma checksum "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24cebf861f03fe81b1772852301368975953543c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProniaAdmin_Views_Plant_Detail), @"mvc.1.0.view", @"/Areas/ProniaAdmin/Views/Plant/Detail.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Ap204_Pronia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cebf861f03fe81b1772852301368975953543c", @"/Areas/ProniaAdmin/Views/Plant/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54289a8a9cc2330d52892068f548cd18ef4ea07", @"/Areas/ProniaAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ProniaAdmin_Views_Plant_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plant>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width:150px; height:90px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-primary"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">SKUCode</th>
            <th scope=""col"">Shipping</th>
            <th scope=""col"">Request</th>
            <th scope=""col"">Another Image</th>
            <th scope=""col"">Main Image</th>
            <th scope=""col"">PlantCategories</th>

        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.SKUCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Shipping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
           Write(Model.Request);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <div class=\"d-fex\">\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
                     foreach (var img in Model.PlantImages.Where(i => i.IsMain == false))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24cebf861f03fe81b1772852301368975953543c6560", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1158, "~/assets/images/website-images/", 1158, 31, true);
#nullable restore
#line 37 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
AddHtmlAttributeValue("", 1189, img.ImagePath, 1189, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </td>\r\n            <td>\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24cebf861f03fe81b1772852301368975953543c8507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1387, "~/assets/images/website-images/", 1387, 31, true);
#nullable restore
#line 44 "C:\Users\user\Desktop\Ap204_Pronia\Ap204_Pronia\Areas\ProniaAdmin\Views\Plant\Detail.cshtml"
AddHtmlAttributeValue("", 1418, Model.PlantImages.FirstOrDefault(i=>i.IsMain==true)?.ImagePath, 1418, 63, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plant> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
