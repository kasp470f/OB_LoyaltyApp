#pragma checksum "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3270d80c45bf8767d5b6787e9e03495eb3faee"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using BethanysPieShopHRM.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using BethanysPieShopHRM.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using BethanysPieShopHRM.UI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
using BethanysPieShopHRM.UI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/survey/{SurveyId}")]
    public partial class SurveyDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "entity-edit");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
     if (Survey == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <h1 class=\"page-title\">Survey Details</h1>\r\n            </div>\r\n        </div>\r\n        <br>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xs-12 col-sm-6");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<div class=\"card-header\">\r\n                        Question and Description\r\n                    </div>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "card-title");
#nullable restore
#line 27 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(22, Survey.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text");
#nullable restore
#line 28 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(26, Survey.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-xs-12 col-sm-6");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.AddMarkupContent(37, "<div class=\"card-header\">\r\n                        Quick Stats\r\n                    </div>\r\n                    ");
            __builder.OpenElement(38, "ul");
            __builder.AddAttribute(39, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "list-group-item");
            __builder.AddContent(43, "Average Rating: ");
#nullable restore
#line 38 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(44, AverageRating);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "list-group-item");
            __builder.AddContent(48, "Highest Rating: ");
#nullable restore
#line 39 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(49, HighestRating);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "list-group-item");
            __builder.AddContent(53, "Lowest Rating: ");
#nullable restore
#line 40 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(54, LowestRating);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "list-group-item");
            __builder.AddContent(58, "Number of Responses: ");
#nullable restore
#line 41 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(59, Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-12");
            __builder.AddMarkupContent(70, "\r\n                <br>\r\n                ");
            __builder.AddMarkupContent(71, "<h3>Answers</h3>\r\n                ");
            __builder.OpenElement(72, "table");
            __builder.AddAttribute(73, "class", "table table-striped");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<thead>\r\n                        <tr>\r\n                            <th>Id</th>\r\n                            <th>Response</th>\r\n                            <th>Rating</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(76, "tbody");
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 59 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
                         foreach (var answer in Survey.Answers)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                            ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "td");
#nullable restore
#line 62 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(82, answer.AnswerId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "td");
#nullable restore
#line 63 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(85, answer.Response);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "td");
#nullable restore
#line 64 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
__builder.AddContent(88, answer.Rating);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 66 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 71 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Skies\Documents\GitHub\OB_LoyaltyApp\blazor-enterprise\BethanysPieShopHRM.UI\Pages\SurveyDetails.razor"
       
    [Inject]
    private ISurveyDataService surveyService { get; set; }

    [Parameter]
    public string SurveyId { get; set; }

    public double AverageRating { get; set; }

    public double LowestRating { get; set; }

    public double HighestRating { get; set; }
    
    public double Count { get; set; }

    public Survey Survey { get; set; } = new Survey() { Answers = new List<Answer>() };

    protected override async Task OnInitializedAsync()
    {
        Survey = await surveyService.GetSurveyById(int.Parse(SurveyId));

        if (Survey.Answers == null)
        {
            Survey.Answers = new List<Answer>();
        }

        if (Survey.Answers.Count > 0)
        {
            AverageRating = Survey.Answers.Select(x => x.Rating).Sum() / Survey.Answers.Count;

            HighestRating = Survey.Answers.OrderByDescending(x => x.Rating).FirstOrDefault().Rating;

            LowestRating = Survey.Answers.OrderBy(x => x.Rating).FirstOrDefault().Rating;

            Count = Survey.Answers.Count;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591