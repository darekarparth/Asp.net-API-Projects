#pragma checksum "C:\Users\OWNER\source\repos\ShoppingCart2\ShoppingCart2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102fdc1ed7fa9787c018a48cdda9685e780bb479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\OWNER\source\repos\ShoppingCart2\ShoppingCart2\Views\_ViewImports.cshtml"
using ShoppingCart2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OWNER\source\repos\ShoppingCart2\ShoppingCart2\Views\_ViewImports.cshtml"
using ShoppingCart2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102fdc1ed7fa9787c018a48cdda9685e780bb479", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca1dda8cbdb90b634c070967eb0c216baa68143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\OWNER\source\repos\ShoppingCart2\ShoppingCart2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "102fdc1ed7fa9787c018a48cdda9685e780bb4793437", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" integrity=""sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu"" crossorigin=""anonymous"">

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js"" integrity=""sha384-nvAa0+6Qg9clwYCGGPpDQLVpLNn0fRaROjHqs13t4Ggj3Ez50XnGQqc/r8MhnRDZ"" crossorigin=""anonymous""></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"" integrity=""sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd"" crossorigin=""anonymous""></script>


");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "102fdc1ed7fa9787c018a48cdda9685e780bb4795193", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container-fluid\">\r\n        <h2 class=\"col-xs-12 text-center\">Online Ecommerce Store</h2>\r\n\r\n    </div>\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <div id=\"mytable\" data-bind=\"foreach:items\">\r\n            <div");
                BeginWriteAttribute("class", " class=\"", 1088, "\"", 1096, 0);
                EndWriteAttribute();
                WriteLiteral(" data-bind=\"\">\r\n\r\n                <div class=\"row-fluid\">\r\n                    <div class=\"col-md-4\">\r\n                        <br>\r\n                        <div style=\"border-style:groove\"><img src=\"./css/Image3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1314, "\"", 1320, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:100%""></div>
                        <h5>Id: <b><span data-bind=""text:Id"" /></b></h5>
                        <h5>Product Name: <b><span data-bind=""text:Name"" /></b></h5>
                        <h5>Price: <b><span data-bind=""text:Price"" /></b></h5>
                        <button data-bind=""click: $root.save"" type=""submit"" class=""btn btn-warning"">Add to Cart</button>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <hr />

    <!--------------------------------------------------------------->
    <div class=""container-fluid"">
        <h4><b>My Cart</b></h4>
        <table class=""table table-striped table-hover table-fluid"">
            <thead>
                <tr>
                    <td><b>Name</b></td>
");
                WriteLiteral("                    <td><b>Price/unit</b></td>\r\n");
                WriteLiteral("                    <td><b>Delete</b></td>\r\n                </tr>\r\n\r\n            </thead>\r\n            <tbody data-bind=\"foreach:items2\">\r\n                <tr>\r\n                    <td><span data-bind=\"text:$data.name\"></span></td>\r\n");
                WriteLiteral("                    <td><span data-bind=\"text:$data.price\"></span></td>\r\n\r\n");
                WriteLiteral(@"                    <!--  -->
                    <td><button type=""submit"" data-bind=""click: $root.DelProduct"" class=""glyphicon glyphicon-trash"" style=""color:red; border: none;"" data-bind=""""></button></td>

                </tr>
            </tbody>
        </table>


    </div>







    <script src=""./js/Main.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.5.1/knockout-latest.js"" integrity=""sha512-2AL/VEauKkZqQU9BHgnv48OhXcJPx9vdzxN1JrKDVc4FPU/MEE/BZ6d9l0mP7VmvLsjtYwqiYQpDskK9dG8KBA=="" crossorigin=""anonymous""></script>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src=""https://code.jquery.com/jquery-1.12.4.min.js"" integrity=""sha384-nvAa0+6Qg9clwYCGGPpDQLVpLNn0fRaROjHqs13t4Ggj3Ez50XnGQqc/r8MhnRDZ"" crossorigin=""anonymous""></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"" integrity=""sha3");
                WriteLiteral("84-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd\" crossorigin=\"anonymous\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
