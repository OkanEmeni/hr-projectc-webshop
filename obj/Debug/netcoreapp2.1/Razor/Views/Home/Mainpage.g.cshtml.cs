#pragma checksum "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698bc709788ab5681588c255f9aeb45ce5504ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mainpage), @"mvc.1.0.view", @"/Views/Home/Mainpage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Mainpage.cshtml", typeof(AspNetCore.Views_Home_Mainpage))]
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
#line 1 "D:\Downloads\WebstoreZip\webStore2-master\Views\_ViewImports.cshtml"
using klaas;

#line default
#line hidden
#line 2 "D:\Downloads\WebstoreZip\webStore2-master\Views\_ViewImports.cshtml"
using klaas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698bc709788ab5681588c255f9aeb45ce5504ac5", @"/Views/Home/Mainpage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352b5a98eed0cfcd5effdcb73eae774d1cd82482", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mainpage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<klaas.products.Productwaarde>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mainpage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
  
    Layout = "";
 

#line default
#line hidden
            BeginContext(76, 764, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">



  <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
  <a class=""navbar-brand"" href=""#"">Webshop</a>
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
    <ul class=""navbar-nav mr-auto"">
      <li class=""nav-item active"">
        <a class=""nav-link""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 840, "\"", 878, 1);
#line 18 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 847, Url.Action("Mainpage", "Home"), 847, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(879, 119, true);
            WriteLiteral(">Home <span class=\"sr-only\">(current)</span></a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 998, "\"", 1036, 1);
#line 21 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 1005, Url.Action("Login", "Account"), 1005, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 353, true);
            WriteLiteral(@">Login</a>
      </li>
      <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
          Admin
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
          <a class=""dropdown-item""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1390, "\"", 1430, 1);
#line 28 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 1397, Url.Action("Create", "Products"), 1397, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1431, 63, true);
            WriteLiteral(">Maak product soort aan</a>\r\n          <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1494, "\"", 1535, 1);
#line 29 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 1501, Url.Action("Create2", "Products"), 1501, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 286, true);
            WriteLiteral(@">Voeg product toe</a>
          <div class=""dropdown-divider""></div>
          <a class=""dropdown-item"" href=""#"">Something else here</a>
        </div>
      </li>
      <li class=""nav-item"">
        <a class=""nav-link disabled"" href=""#"">Disabled</a>
      </li>
    </ul>
    ");
            EndContext();
            BeginContext(1822, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "698bc709788ab5681588c255f9aeb45ce5504ac57421", async() => {
                BeginContext(1861, 195, true);
                WriteLiteral("\r\n      <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n      <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2063, 67, true);
            WriteLiteral("\r\n  </div>\r\n</nav>  \r\n<br>\r\n\r\n<h2>Boten</h2>\r\n\r\n<h4>Products</h4>\r\n");
            EndContext();
#line 49 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
  var i = 1;

#line default
#line hidden
            BeginContext(2147, 22, true);
            WriteLiteral("\r\n<div class=\"row\" >\r\n");
            EndContext();
#line 53 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
 foreach (var item in Model)
        {
                if ((i%2)!=0){ 
                    

#line default
#line hidden
            BeginContext(2265, 192, true);
            WriteLiteral("                        <div class=\"col\">\r\n                        <div class=\"card\" style=\"width: 25rem;\">\r\n                            <div class=\"card-body\">\r\n                              ");
            EndContext();
            BeginContext(2457, 511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "698bc709788ab5681588c255f9aeb45ce5504ac510015", async() => {
                BeginContext(2485, 131, true);
                WriteLiteral("\r\n                                <div id=\"container\" class=\"form-group\">\r\n                                <h5 class=\"card-title\" >");
                EndContext();
                BeginContext(2617, 10, false);
#line 62 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2627, 63, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\" >$ ");
                EndContext();
                BeginContext(2691, 10, false);
#line 63 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(2701, 70, true);
                WriteLiteral("</p>\r\n                                <input type=\"hidden\" name = \"hi\"");
                EndContext();
                BeginWriteAttribute("value", " value =  \'", 2771, "\'", 2793, 1);
#line 64 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 2782, item.Title, 2782, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2794, 167, true);
                WriteLiteral(" />\r\n                                <input type=\"submit\" class=\"btn btn-primary\" value=\"Buy\"  >\r\n                                </div>\r\n                             ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2968, 111, true);
            WriteLiteral("             \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 71 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                
                }
                else{

#line default
#line hidden
            BeginContext(3139, 189, true);
            WriteLiteral("                    <div class=\"col\">\r\n                        <div class=\"card\" style=\"width: 25rem;\">\r\n                            <div class=\"card-body\">\r\n                               ");
            EndContext();
            BeginContext(3328, 511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "698bc709788ab5681588c255f9aeb45ce5504ac513879", async() => {
                BeginContext(3356, 131, true);
                WriteLiteral("\r\n                                <div id=\"container\" class=\"form-group\">\r\n                                <h5 class=\"card-title\" >");
                EndContext();
                BeginContext(3488, 10, false);
#line 79 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3498, 63, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\" >$ ");
                EndContext();
                BeginContext(3562, 10, false);
#line 80 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3572, 70, true);
                WriteLiteral("</p>\r\n                                <input type=\"hidden\" name = \"hi\"");
                EndContext();
                BeginWriteAttribute("value", " value =  \'", 3642, "\'", 3664, 1);
#line 81 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
WriteAttributeValue("", 3653, item.Title, 3653, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3665, 167, true);
                WriteLiteral(" />\r\n                                <input type=\"submit\" class=\"btn btn-primary\" value=\"Buy\"  >\r\n                                </div>\r\n                             ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3839, 173, true);
            WriteLiteral(" \r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                     <div class=\"w-100\"></div>\r\n                    <br>\r\n");
            EndContext();
#line 90 "D:\Downloads\WebstoreZip\webStore2-master\Views\Home\Mainpage.cshtml"
                }
            i++;
        }

#line default
#line hidden
            BeginContext(4060, 706, true);
            WriteLiteral(@"</div>

<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>


         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<klaas.products.Productwaarde>> Html { get; private set; }
    }
}
#pragma warning restore 1591
