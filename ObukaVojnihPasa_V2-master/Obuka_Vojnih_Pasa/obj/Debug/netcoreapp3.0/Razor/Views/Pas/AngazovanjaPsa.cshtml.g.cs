#pragma checksum "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab7d7f7b231a0401297d9f25726e9b29111e806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pas_AngazovanjaPsa), @"mvc.1.0.view", @"/Views/Pas/AngazovanjaPsa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab7d7f7b231a0401297d9f25726e9b29111e806", @"/Views/Pas/AngazovanjaPsa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181dbab99011c9f68b19885cef3427f7642f3ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pas_AngazovanjaPsa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sortable/Contents/bootstrap-sortable.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sortable/Scripts/bootstrap-sortable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ab7d7f7b231a0401297d9f25726e9b29111e8065006", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
 if (Model.Count() == 0)
{
    if (ViewBag.Init == "")
    {

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover"" id=""tblAngazovanja"">

            <tr>

                <th>
                    <h3><i class=""fa fa-exclamation-triangle""></i>  Lista je prazna</h3>
                </th>


            </tr>

        </table>
");
#nullable restore
#line 26 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
    }
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table sortable"" cellpadding=""0"" cellspacing=""0"" id=""tblAngazovanja"">
        <thead id=""tbl-header"">
            <tr>

                <th>
                    <i class=""fa fa-tasks""></i> Zadatak
                </th>
                <th>
                    <i class=""fa fa-map-marked-alt""></i> Teren
                </th>
                <th>
                    <i class=""fa fa-calendar-check""></i>  Datum
                </th>
                <th>
                    Ocena
                </th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Zadatak.NazivZadatka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Zadatak.Teren));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DatumUnosaOcene));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ocena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 74 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\AngazovanjaPsa.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ab7d7f7b231a0401297d9f25726e9b29111e80610151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
