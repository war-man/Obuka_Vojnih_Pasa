#pragma checksum "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1991c91d856f76ec081ae4f1bbc170790c7acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pas_Delete), @"mvc.1.0.view", @"/Views/Pas/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1991c91d856f76ec081ae4f1bbc170790c7acd", @"/Views/Pas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181dbab99011c9f68b19885cef3427f7642f3ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Obuka_Vojnih_Pasa.Models.Domain.Pas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Otkaži"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 20px; width: 140px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n<div class=\"edit\">\n    <div class=\"container\">\n        <div class=\"row main\">\n            <div class=\"main-login main-center\">\n                <h5>Da li ste sigurni da zelite da obrišete podatke o psu? </h5>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef1991c91d856f76ec081ae4f1bbc170790c7acd6689", async() => {
                WriteLiteral("\n                \n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef1991c91d856f76ec081ae4f1bbc170790c7acd6983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Broj zdravstvene knjižice</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-notes-medical fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 23 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.BrojZdravstveneKnjizice, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Ime psa</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-dog fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 34 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.Ime, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Rasa</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-bone fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 44 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.Rasa, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Pol</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-venus-mars fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 55 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.Pol, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    
                            </div>
                        </div>
                    </div>



                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Datum rođenja</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-calendar-alt fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 68 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.DatumRodjenja,"{0:dd/MM/yyyy}", new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""cols-sm-2 control-label"">Obuka</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-basketball-ball fa"" aria-hidden=""true""></i></span>
                                ");
#nullable restore
#line 78 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Pas\Delete.cshtml"
                           Write(Html.TextBoxFor(model => model.Obuka.Naziv, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>



                    <div class=""form-group"" style=""padding-top:10px"">

                        <input type=""submit"" class=""btn-submit"" value="" Potvrdi brisanje ""/>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef1991c91d856f76ec081ae4f1bbc170790c7acd14143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Obuka_Vojnih_Pasa.Models.Domain.Pas> Html { get; private set; }
    }
}
#pragma warning restore 1591
