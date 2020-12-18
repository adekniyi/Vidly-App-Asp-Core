#pragma checksum "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "186fcd1eeae6a9d30d7a0d3e7093e76ee3a181ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_New), @"mvc.1.0.view", @"/Views/Movie/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186fcd1eeae6a9d30d7a0d3e7093e76ee3a181ef", @"/Views/Movie/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52093db50c141b0d3d80ca30f6722fbf34687660", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly_App.ViewModel.MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create A New Movie</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
 using (Html.BeginForm("Create", "Movie"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.LabelFor(m => m.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.LabelFor(m => m.Movie.ReleasedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.ReleasedDate, "{0:d MMM yyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.LabelFor(m => m.Movie.GenreId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.DropDownListFor(m => m.Movie.GenreId, new SelectList(Model.Genres, "Id", "Name"), "Select Membership Type", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.LabelFor(m => m.Movie.NumberInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.NumberInStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\Vidly App\Vidly App\Views\Movie\New.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly_App.ViewModel.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
