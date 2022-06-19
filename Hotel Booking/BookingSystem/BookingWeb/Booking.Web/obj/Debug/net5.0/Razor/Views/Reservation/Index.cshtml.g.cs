#pragma checksum "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d08c6e10eb9ee588fc18d50c62e45eb66cb78b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
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
#line 1 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\_ViewImports.cshtml"
using Booking.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\_ViewImports.cshtml"
using BookingWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d08c6e10eb9ee588fc18d50c62e45eb66cb78b5f", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938a264c6a9114d5b30148e71587d80d071c8d65", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookingWeb.Models.Reservation>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Manage Reservations";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n<div class=\"management-header my-5\">\r\n    <h2 class=\"text-white\">Manage Reservations</h2>\r\n</div>\r\n");
#nullable restore
#line 10 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
 if(Model.Count() > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-dark"">
      <thead>
        <tr>
          <th scope=""col"">#</th>
          <th scope=""col"">Full Name</th>
          <th scope=""col"">Email</th>
          <th scope=""col"">Phone</th>
          <th scope=""col"">Room ID</th>
          <th scope=""col"">Room Type</th>
          <th scope=""col"">No Of Persons</th>
          <th scope=""col"">Total Price</th>
          <th scope=""col"">Date From</th>
          <th scope=""col"">Date To</th>
          <th scope=""col"">Reservation Date</th>
          <th scope=""col"">Handle</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 29 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
         foreach (var reservation in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 32 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
                           Write(reservation.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 33 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.ContactInformation.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
                                                         Write(reservation.ContactInformation.MidName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
                                                                                                 Write(reservation.ContactInformation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.ContactInformation.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.ContactInformation.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.Room.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.Room.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.NoOfPersons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.DateFrom.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.DateTo.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
               Write(reservation.CreatedAt.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d08c6e10eb9ee588fc18d50c62e45eb66cb78b5f10218", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
                                                                WriteLiteral(reservation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n");
#nullable restore
#line 50 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-white\">There are no reservations availiable now...</h4>        \r\n");
#nullable restore
#line 54 "D:\Development\Projects\Asp.net core\Hotel Booking System\Hotel Booking\BookingSystem\BookingWeb\Booking.Web\Views\Reservation\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BookingWeb.Models.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591