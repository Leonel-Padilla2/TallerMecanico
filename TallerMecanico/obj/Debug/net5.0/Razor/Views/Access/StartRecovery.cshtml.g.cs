#pragma checksum "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297c6f68a47a9fa96b7405451429b3be2a59e8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Access_StartRecovery), @"mvc.1.0.view", @"/Views/Access/StartRecovery.cshtml")]
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
#line 1 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\_ViewImports.cshtml"
using TallerMecanico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\_ViewImports.cshtml"
using TallerMecanico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
using TallerMecanico.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"297c6f68a47a9fa96b7405451429b3be2a59e8e6", @"/Views/Access/StartRecovery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7101151fd0d31cc00d151cbadba888642d3901ed", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Access_StartRecovery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecoveryVm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
  
    ViewData["Title"] = "StartRecovery";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"recovery\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297c6f68a47a9fa96b7405451429b3be2a59e8e64544", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
         if (!string.IsNullOrEmpty(@ViewBag.Error))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div");
                BeginWriteAttribute("class", " class=\"", 355, "\"", 384, 1);
#nullable restore
#line 12 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
WriteAttributeValue("", 363, ViewBag.ClaseMensaje, 363, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"alert\" id=\"success-alert\">\r\n                <strong> ");
#nullable restore
#line 13 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
                    Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            </div>\r\n");
#nullable restore
#line 15 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <ul>
            <li style=""color:white;""> <i class=""bi bi-gear-fill""></i> Taller Mecánico Ensigna</li>

        </ul>


        <br>
        <br>
        <div class=""card"" style=""text-align:center;"">

            <div class=""card-header"" style=""background-color:#060724; color: white;""> Recuperación de contraseña</div>
            <br>

            <div class=""alert alert-info"">
                <p class=""description""><i class=""bi bi-info-circle-fill""></i> Se le enviará un enlace a su correo electrónico donde podra cambiar su contraseña.</p>
            </div>


            ");
#nullable restore
#line 35 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
       Write(Html.TextBoxFor(d=>d.Email,null,new{@class="form-control custom-input"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br>\r\n            <br>\r\n            <div class=\"submit\">\r\n                <input type=\"submit\" id=\"button-recovery\" value=\" Recuperar\" />\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
         if (!ViewData.ModelState.IsValid)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-danger\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
           Write(Html.ValidationMessageFor(d => d.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "C:\Users\Marcelo Lopez\Documents\GitHub\TallerMecanico\TallerMecanico\Views\Access\StartRecovery.cshtml"
AddHtmlAttributeValue("", 219, Url.Content("~/Access/StartRecovery"), 219, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecoveryVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
