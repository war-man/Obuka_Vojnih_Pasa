#pragma checksum "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126048e8b7b9eb7b78abc3e2986b07cd5714986d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Angazovanje_Angazovanja), @"mvc.1.0.view", @"/Views/Angazovanje/Angazovanja.cshtml")]
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
#line 1 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\_ViewImports.cshtml"
using Obuka_Vojnih_Pasa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\_ViewImports.cshtml"
using Obuka_Vojnih_Pasa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
using Obuka_Vojnih_Pasa.Models.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126048e8b7b9eb7b78abc3e2986b07cd5714986d", @"/Views/Angazovanje/Angazovanja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181dbab99011c9f68b19885cef3427f7642f3ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Angazovanje_Angazovanja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sortable/Contents/bootstrap-sortable.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistika", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Angazovanje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Izmeni podatke o angažovanju"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Obriši podatke o angažovanju"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sortable/Scripts/bootstrap-sortable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sortable/Scripts/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "126048e8b7b9eb7b78abc3e2986b07cd5714986d8264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
  Instruktor instruktor = null; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
     if (!User.IsInRole("Admin"))
        instruktor = await userManager.FindByIdAsync(userManager.GetUserId(User)) as Instruktor;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Nije pronađeno nijedano angažovanje po unetom kriterijumu pretrage.</h3>\r\n");
#nullable restore
#line 17 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""scroll"">
        <table class=""table sortable"" id=""l"">
            <thead>
                <tr>
                    <th>

                    </th>
                    <th>
                        Pas
                    </th>
                    <th>
                        Naziv zadatka
                    </th>
                    <th style=""width:200px"">
                        Datum realizacije zadatka
                    </th>
                    <th>
                        Datum unosa ocene
                    </th>
                    <th>
                        Ocena
                    </th>

                    <th style=""padding-left:30px"">
                        Akcije
                    </th>


                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 52 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126048e8b7b9eb7b78abc3e2986b07cd5714986d11846", async() => {
                WriteLiteral("   <i class=\"fas fa-paw\" style=\"color:snow\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                                                                              WriteLiteral(item.PasId);

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
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Pas.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Zadatak.NazivZadatka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Zadatak.Datum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DatumUnosaOcene));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ocena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                          
                            var parms = new Dictionary<string, string>
                                                                                        {
                { "PasId",item.PasId.ToString() },
                { "ZadatakId",item.ZadatakId.ToString() }
                        };
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                         if (item.Zadatak.Status.Equals("Ocenjen"))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                             if ((instruktor != null && item.Pas.ObukaId == instruktor.ObukaId) || User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126048e8b7b9eb7b78abc3e2986b07cd5714986d17845", async() => {
                WriteLiteral("<i class=\" fas fa-pencil-alt\" style=\"color:snow;margin-left:20px\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 87 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 89 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                                     if ((await authorizationService.AuthorizeAsync(User, "AngazovanjePolicy")).Succeeded)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126048e8b7b9eb7b78abc3e2986b07cd5714986d20329", async() => {
                WriteLiteral("<i class=\" fas fa-trash-alt\" style=\"color:snow;margin-left:20px\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 91 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n");
#nullable restore
#line 94 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <i class=\"fas fa-user-alt-slash\" style=\"color:snow;margin-left:20px\" title=\"Nemate dozvolu za pristup ovoj opciji\"></i>\r\n                                </td>\r\n");
#nullable restore
#line 101 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><i class=\"fa fa-history\"> Ocenjivanje u toku...</i></td>\r\n");
#nullable restore
#line 106 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 108 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 113 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Angazovanja.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "126048e8b7b9eb7b78abc3e2986b07cd5714986d24835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126048e8b7b9eb7b78abc3e2986b07cd5714986d25950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126048e8b7b9eb7b78abc3e2986b07cd5714986d26991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
