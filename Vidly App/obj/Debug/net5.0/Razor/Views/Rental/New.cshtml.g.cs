#pragma checksum "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Rental\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2278a20ef399a2da01c90e80ca7d4d8461c8f371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rental_New), @"mvc.1.0.view", @"/Views/Rental/New.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\_ViewImports.cshtml"
using Vidly_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\_ViewImports.cshtml"
using Vidly_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2278a20ef399a2da01c90e80ca7d4d8461c8f371", @"/Views/Rental/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52093db50c141b0d3d80ca30f6722fbf34687660", @"/Views/_ViewImports.cshtml")]
    public class Views_Rental_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Rental\New.cshtml"
   
    ViewBag.Title = "New Rental Form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2278a20ef399a2da01c90e80ca7d4d8461c8f3713423", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label>Customer</label>\r\n        <input id=\"customer\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 165, "\"", 173, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <input type=\"hidden\" id=\"hfCustomerId\" runat=\"server\" />\r\n    </div> \r\n    <div class=\"form-group\">\r\n        <label>Movies</label>\r\n        <input id=\"movie\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 377, "\"", 385, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    </div>\r\n    <button class=\"btn btn-primary\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n5\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var vm = {
                moviesId:[]
            };
            $('#customer').autocomplete({
               // minLength:2,
                source: ""/api/customers/search""
                //source: function (request, response) {
                //    $.ajax({
                //        url: ,
                //        method: ""post"",
                //        contentType: ""application/json;charset=utf-8"",
                //        data: JSON.stringify({ term: request.term }),
                //        dataType: ""json"",
                //        success: function (data) {
                //           // console.log(data)
                //            response($.map(data.d, function (item) {
                //                //return item.name;
                //                //console.log(item.Name)
                //                return {
                //                    label: item.split('-')[0],
             ");
                WriteLiteral(@"   //                    val: item.split('-')[1]
                //                }
                //            }))
                //        },
                //        error: function (err) {
                //            console.log(err);
                //        }
                //    });
                //},
                //select: function (e, i) {
                //    $('#hfCustomerId').val(i.item.val);
                //    vm.customerId = i.item.customerId
                //},
                //minLength:1
            })


            $('#movie').autocomplete({
                // minLength:2,
                source: function (request, response) {
                    $.ajax({
                        url: ""/api/movies"",
                        method: ""get"",
                        contentType: ""application/json;charset=utf-8"",
                        data: JSON.stringify({ term: request.term }),
                        dataType: ""json"",
                        succes");
                WriteLiteral(@"s: function (data) {
                            // console.log(data)
                            response($.map(data, function (item) {
                                return item.name;
                                vm.movieId = item.customerId
                                //console.log(item.Name)
                            }))
                        },
                        error: function (err) {
                            console.log(err);
                        }
                    });
                },
                select: function (e, movie) {
                    $('#movie').append(""<li>"" + movie.name + ""<li>"");
                    $('#movie').val(movie.name);
                    vm.moviesId.push(movie.movieId);
                    console.log(movie.name);
                },
                minLength: 1
            })

      


        });
    </script>
");
            }
            );
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
