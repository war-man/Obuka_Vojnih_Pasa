#pragma checksum "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "727a9ab0fdb762ed2488d778adab0c5ceb421f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Angazovanje_Index), @"mvc.1.0.view", @"/Views/Angazovanje/Index.cshtml")]
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
#line 2 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
using Obuka_Vojnih_Pasa.Models.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727a9ab0fdb762ed2488d778adab0c5ceb421f48", @"/Views/Angazovanje/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181dbab99011c9f68b19885cef3427f7642f3ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Angazovanje_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
  
    List<Zadatak> zadaci = ViewBag.ListaZadataka;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<br />\n<h3 id=\"confirm\">\n");
#nullable restore
#line 10 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
     if (@ViewBag.Message != string.Empty)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a onclick=\"Ok()\" style=\"cursor: pointer\" class=\"btn btn-sm\">OK <i class=\"fa fa-check-circle\"></i></a>\n");
#nullable restore
#line 14 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727a9ab0fdb762ed2488d778adab0c5ceb421f486713", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-3"">
            <input type=""text"" id=""kriterijum"" placeholder=""Pretraga po imenu psa .."" class=""form-control"">
        </div>

        <div class=""form-group col-md-3"">

            <select class=""form-control"" id=""zadatakId"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727a9ab0fdb762ed2488d778adab0c5ceb421f487296", async() => {
                    WriteLiteral("Svi zadaci");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 27 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
                 foreach (Zadatak item in zadaci)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727a9ab0fdb762ed2488d778adab0c5ceb421f488848", async() => {
#nullable restore
#line 29 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
                                      Write(item.NazivZadatka);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"
                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\Kaca\Desktop\ObukaVojnihPasa_V2-master\ObukaVojnihPasa_V2-master\Obuka_Vojnih_Pasa\Views\Angazovanje\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\n        </div>\n\n        <div class=\"form-group col-md-4\">\n            <input id=\"btnSearch\" type=\"button\" class=\"btn btn-sm btn-primary btn-outline-light\" value=\"Pretraži\" />\n        </div>\n       \n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""angazovanja""> </div>



<script>
    function Ok() {
        var x = document.getElementById(""confirm"");
        x.style.display = ""none"";
    }

    $(function () {
        GetAngazovanja();
    });
    $('#btnSearch').on('click', function (e) {
        var filters = {
            kriterijum: $('#kriterijum').val(),
            zadatakId: $('#zadatakId').val()
        }


        GetAngazovanja(filters);
    });
    function GetAngazovanja(filters) {
        $.ajax({
            url: '/Angazovanje/Angazovanja',
            type: 'POST',
            cache: false,
            async: true,
            dataType: ""html"",
            data: filters
        })
            .done(function (result) {
                $('#angazovanja').html(result);
            }).fail(function (xhr) {
                console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
            });

    }

</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727a9ab0fdb762ed2488d778adab0c5ceb421f4813296", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Obuka_Vojnih_Pasa.Models.Domain.Angazovanje> Html { get; private set; }
    }
}
#pragma warning restore 1591
