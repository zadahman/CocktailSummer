#pragma checksum "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175b01bebe545c3c1e02af482c4da47a32698d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditCocktail), @"mvc.1.0.view", @"/Views/Home/EditCocktail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175b01bebe545c3c1e02af482c4da47a32698d74", @"/Views/Home/EditCocktail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditCocktail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CocktailSummer.Models.Cocktail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
  
    ViewBag.Title = "Edit Cocktail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-header\">\n        <h3>\n            ");
#nullable restore
#line 10 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h3>\n    </div>\n    <div class=\"card-body\">\n\n        <div class=\"form-horizontal\">\n");
#nullable restore
#line 16 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group row \">\n                    ");
#nullable restore
#line 19 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
               Write(Html.LabelFor(model => model.Name, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
#nullable restore
#line 21 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
                   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"form-group row\">\n                    ");
#nullable restore
#line 26 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
               Write(Html.Label("GlassType", "Glass Type", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
#nullable restore
#line 28 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
                   Write(Html.EditorFor(model => model.GlassType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"form-group row\">\n                    ");
#nullable restore
#line 33 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
               Write(Html.Label("DrinkType", "Drink Type", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
#nullable restore
#line 35 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
                   Write(Html.EditorFor(model => model.DrinkType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"form-group row\">\n                    ");
#nullable restore
#line 40 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
               Write(Html.Label("DrinkCategory", "Drink Category", new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
#nullable restore
#line 42 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
                   Write(Html.EditorFor(model => model.DrinkCategory, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"form-group row\">\n                    ");
#nullable restore
#line 47 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
               Write(Html.LabelFor(model => model.Instructions, new { @class = "col-sm-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"col-sm-10\">\n                        ");
#nullable restore
#line 49 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
                   Write(Html.TextAreaFor(model => model.Instructions, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"form-group\">\n                    <div class=\"col-md-offset-2\">\n                        <input type=\"submit\" value=\"Save\" class=\"btn btn-block btn-primary\" />\n                    </div>\n                </div>\n");
#nullable restore
#line 58 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div>\n                ");
#nullable restore
#line 61 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/EditCocktail.cshtml"
           Write(Html.ActionLink("Back to List", "Favorites"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n            $(\".active\").removeClass(\"active\");\n            $(\"#link-favorite\").addClass(\"active\");\n        });\n\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CocktailSummer.Models.Cocktail> Html { get; private set; }
    }
}
#pragma warning restore 1591