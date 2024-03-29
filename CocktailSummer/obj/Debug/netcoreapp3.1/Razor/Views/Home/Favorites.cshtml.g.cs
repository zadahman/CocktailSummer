#pragma checksum "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8dffc626e2bee1e39d5f494facc880579de7fc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Favorites), @"mvc.1.0.view", @"/Views/Home/Favorites.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8dffc626e2bee1e39d5f494facc880579de7fc2", @"/Views/Home/Favorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Favorites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CocktailSummer.Models.Cocktail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
  
    ViewData["Title"] = "Your Favorite Cocktails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card mt-3 pt-2\">\n    <div class=\"card-header\">\n        <h3>");
#nullable restore
#line 11 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    </div>\n    <div class=\"card-body\">\n        <table class=\"table table-striped\">\n            <thead>\n                <tr class=\"table-info\">\n                    <th>\n                        ");
#nullable restore
#line 18 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 21 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayName("Drink Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 24 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayName("Glass Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 27 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayName("Drink Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 30 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayNameFor(model => model.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 33 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                   Write(Html.DisplayName("Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <th></th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 40 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 1330, "\"", 1343, 1);
#nullable restore
#line 44 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 1335, item.Id, 1335, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <td>\n                                ");
#nullable restore
#line 46 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 49 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DrinkType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 52 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GlassType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 55 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DrinkCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 58 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n");
#nullable restore
#line 61 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient1))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 64 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient2))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 68 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient3))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient3));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 72 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient4))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient4));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient4));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 76 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient5))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient5));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient5));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 80 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient6))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient6));

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient6));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 84 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient7))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient7));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient7));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 88 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient8))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient8));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 92 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient9))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient9));

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient9));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 96 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient10))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient10));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 100 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient11))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient11));

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient11));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 104 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient12))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient12));

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient12));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 108 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient13))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient13));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient13));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 112 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient14))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient14));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient14));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 116 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient15))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient15));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient15));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n");
#nullable restore
#line 120 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n                                <p>\n                                    <img title=\"Click to View\"");
            BeginWriteAttribute("src", " src=\"", 6714, "\"", 6735, 1);
#nullable restore
#line 124 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 6720, item.ImageLink, 6720, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" height=\"30\" type=\"button\" class=\"btn btn-sm bs-tooltip-bottom\" data-toggle=\"modal\" data-target=\"#pop-");
#nullable restore
#line 124 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                                                                                                                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\n                                </p>\n\n                                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 6955, "\"", 6972, 2);
            WriteAttributeValue("", 6960, "pop-", 6960, 4, true);
#nullable restore
#line 127 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 6964, item.Id, 6964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"cocktailImageLabel\" aria-hidden=\"true\">\n                                    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 7204, "\"", 7225, 1);
#nullable restore
#line 129 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 7210, item.ImageLink, 7210, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                    </div>
                                </div>
                            </td>
                            <td>
                                <input type=""button"" title=""Edit"" class=""btn btn btn-outline-info btn-sm mr-2"" value=""Edit""");
            BeginWriteAttribute("onclick", " onclick=\"", 7502, "\"", 7585, 3);
            WriteAttributeValue("", 7512, "location.href=\'", 7512, 15, true);
#nullable restore
#line 134 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 7527, Url.Action("EditCocktail", "Home", new { id = item.Id }), 7527, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7584, "\'", 7584, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                                <button class=\"btn btn btn-outline-info btn-sm mt-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7674, "\"", 7708, 3);
            WriteAttributeValue("", 7684, "deleteCocktail(", 7684, 15, true);
#nullable restore
#line 135 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
WriteAttributeValue("", 7699, item.Id, 7699, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7707, ")", 7707, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">Delete</button>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 138 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        function editing(ctId) {\n             $.ajax({\n                type: \'GET\',\n                url: \'");
#nullable restore
#line 152 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
                 Write(Url.Action("EditCocktail", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=' + ctId,
                dataType: 'json',
                contentType: ""application/json; charset=utf-8"",
                success: function (response) {
                    alert(response);
                },
                error: function (err) {
                    alert(err.responseText);
                }
            });
        };

        function deleteCocktail(id) {
        $.ajax({
            type: 'DELETE',
            url: '");
#nullable restore
#line 167 "/Users/zillahadahman/Documents/GitHub/CocktailSummer/CocktailSummer/Views/Home/Favorites.cshtml"
             Write(Url.Action("DeleteCocktail", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=' + id,
            dataType: 'json',
            contentType: ""application/json; charset=utf-8"",
            success: function (response) {
                alert(response);
                window.location.reload();
            },
            error: function (err) {
                alert(err.responseText);
            }
        });
        }

        $(document).ready(function () {
            $("".active"").removeClass(""active"");
            $(""#link-favorite"").addClass(""active"");
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CocktailSummer.Models.Cocktail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
