#pragma checksum "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d512c4252e9a43b498097ae4a7eee5364904f77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LogIn), @"mvc.1.0.view", @"/Views/Account/LogIn.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
using Vidly_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d512c4252e9a43b498097ae4a7eee5364904f77c", @"/Views/Account/LogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52093db50c141b0d3d80ca30f6722fbf34687660", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
  
    ViewBag.Title = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <section id=\"loginForm\">\r\n");
#nullable restore
#line 11 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = ViewBag.ReturnUrl, @class = "form-horizontal", role = "form" }, FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Use a local account to log in.</h4>\r\n                <hr />\r\n");
#nullable restore
#line 16 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
               Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-md-offset-2 col-md-10\">\r\n                        <div class=\"checkbox\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                       Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                       Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Log in"" class=""btn btn-default"" />
                    </div>
                </div>
                <p>
                    ");
#nullable restore
#line 45 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
               Write(Html.ActionLink("Register as a new user", "Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 50 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                          
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h3>Social Logins</h3>\r\n        <hr />\r\n");
#nullable restore
#line 57 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
           
            if(Model.ExternalLogins.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>No external Log in conigured</div>\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d512c4252e9a43b498097ae4a7eee5364904f77c9738", async() => {
                WriteLiteral("\r\n                    <div>\r\n");
#nullable restore
#line 66 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                         foreach(var provider in Model.ExternalLogins)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 3024, "\"", 3046, 1);
#nullable restore
#line 68 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
WriteAttributeValue("", 3032, provider.Name, 3032, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3047, "\"", 3102, 6);
                WriteAttributeValue("", 3055, "Log", 3055, 3, true);
                WriteAttributeValue(" ", 3058, "in", 3059, 3, true);
                WriteAttributeValue(" ", 3061, "using", 3062, 6, true);
                WriteAttributeValue(" ", 3067, "your", 3068, 5, true);
#nullable restore
#line 68 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
WriteAttributeValue(" ", 3072, provider.DisplayName, 3073, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3094, "account", 3095, 8, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 69 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                           Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 71 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
                                                                        WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Account\LogIn.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
