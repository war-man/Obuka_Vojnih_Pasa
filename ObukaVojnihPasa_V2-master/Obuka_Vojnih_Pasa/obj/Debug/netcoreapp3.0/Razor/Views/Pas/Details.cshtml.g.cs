#pragma checksum "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe7b4769311925d635b0f4fc709fb3947dffc9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pas_Details), @"mvc.1.0.view", @"/Views/Pas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe7b4769311925d635b0f4fc709fb3947dffc9a7", @"/Views/Pas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181dbab99011c9f68b19885cef3427f7642f3ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Lista angazovanja izabranog psa</h1>\n");
#nullable restore
#line 8 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
 if (Model.Count() == 0)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n    \n        <p>\n            Ovaj pas do sada nije angazovan na zadacima!\n        </p></div>\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe7b4769311925d635b0f4fc709fb3947dffc9a74842", async() => {
                WriteLiteral("Povratak na listu pasa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 20 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"

}
else
{
  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 29 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Pas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n               \n                <th> Datum rodjenja </th>\n                <th>\n                    ");
#nullable restore
#line 34 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Pas.Obuka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 37 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Pas.Rasa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 40 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Pas.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n               \n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 46 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 50 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pas.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n             \n                <td>\n                    ");
#nullable restore
#line 54 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pas.DatumRodjenja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pas.Obuka.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pas.Rasa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 63 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pas.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                \n            </tr>\n");
#nullable restore
#line 67 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
            WriteLiteral("    <table class=\"table\">\n        <thead>\n            <tr>\n\n                <th>\n                    ");
#nullable restore
#line 76 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Zadatak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    Datum unosa ocene\n                </th>\n                <th>\n                    ");
#nullable restore
#line 82 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Ocena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 88 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n\n                    <td>\n                        ");
#nullable restore
#line 93 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Zadatak.NazivZadatka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 96 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DatumUnosaOcene));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 99 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ocena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                </tr>\n");
#nullable restore
#line 103 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 106 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
