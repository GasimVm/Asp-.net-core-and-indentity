#pragma checksum "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b5ac99fe1436d866c1bc20bd15b9648fc231e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Admin/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Admin_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b5ac99fe1436d866c1bc20bd15b9648fc231e6", @"/Areas/Admin/Views/Admin/Edit.cshtml")]
    public class Areas_Admin_Views_Admin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MebelShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(127, 398, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form  method=""post"" enctype=""multipart/form-data"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input name=""Name"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 525, "\"", 544, 1);
#line 19 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 533, Model.Name, 533, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(545, 267, true);
            WriteLiteral(@" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input name=""Price"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 812, "\"", 832, 1);
#line 24 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 820, Model.Price, 820, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(833, 297, true);
            WriteLiteral(@" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <textarea rows=""5"" name=""Description"" class=""form-control""  >  ");
            EndContext();
            BeginContext(1131, 17, false);
#line 29 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                                                                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 237, true);
            WriteLiteral(" </textarea>\r\n                <span asp-validation-for=\"Description\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"checkbox\">\r\n                    <label>New </label>\r\n");
            EndContext();
#line 35 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                     if (Model.News)
                    {
                        

#line default
#line hidden
            BeginContext(1471, 37, false);
#line 37 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                   Write(Html.CheckBoxFor(model => model.News));

#line default
#line hidden
            EndContext();
#line 37 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                                                              
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1607, 37, false);
#line 41 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                   Write(Html.CheckBoxFor(model => model.News));

#line default
#line hidden
            EndContext();
#line 41 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(1669, 224, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label   class=\"control-label\"></label>\r\n                \r\n                <select class=\"form-control\" name=\"CategoryId\">\r\n");
            EndContext();
#line 50 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                     foreach (var item in ViewBag.Category)
                    {
                        if (item.Name == Model.Category.Name)
                        {

#line default
#line hidden
            BeginContext(2067, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2102, "\"", 2118, 1);
#line 54 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 2110, item.Id, 2110, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2119, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(2130, 9, false);
#line 54 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2139, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 55 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2234, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2269, "\"", 2285, 1);
#line 58 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 2277, item.Id, 2277, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2286, 3, true);
            WriteLiteral("  >");
            EndContext();
            BeginContext(2290, 9, false);
#line 58 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2299, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 59 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                        }


                    }

#line default
#line hidden
            BeginContext(2364, 317, true);
            WriteLiteral(@"
                </select>
                <span asp-validation-for=""CategoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Images</label>
                <input type=""file"" multiple name=""Photo"" class=""form-control""   />

");
            EndContext();
#line 71 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
                 foreach (var item in ViewBag.image)
                {


#line default
#line hidden
            BeginContext(2756, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2776, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3eae0471920c436081f1f2aa0eb3ab84", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2786, "~/images/", 2786, 9, true);
#line 74 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"
AddHtmlAttributeValue("", 2795, item.Name, 2795, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2864, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "C:\Users\ADMIN\source\repos\MebelShop\MebelShop\Areas\Admin\Views\Admin\Edit.cshtml"

                }

#line default
#line hidden
            BeginContext(2887, 216, true);
            WriteLiteral("            </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Edit\" class=\"btn btn-success\" />\r\n                </div>\r\n            </form>\r\n    </div>\r\n</div>\r\n\r\n \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MebelShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
