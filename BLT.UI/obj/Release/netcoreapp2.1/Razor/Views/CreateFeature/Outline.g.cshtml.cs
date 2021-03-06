#pragma checksum "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/CreateFeature/Outline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb56189c672217672f8815bc1e7961407fed7a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateFeature_Outline), @"mvc.1.0.view", @"/Views/CreateFeature/Outline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CreateFeature/Outline.cshtml", typeof(AspNetCore.Views_CreateFeature_Outline))]
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
#line 1 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/_ViewImports.cshtml"
using BLT.UI.ViewModels;

#line default
#line hidden
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/_ViewImports.cshtml"
using BLT.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb56189c672217672f8815bc1e7961407fed7a2", @"/Views/CreateFeature/Outline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a791b0485978c27180504f22272200d41406b7d", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateFeature_Outline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Feature-Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/tbatch27/Desktop/BLTlocal/BLT/BLT.UI/Views/CreateFeature/Outline.cshtml"
  
    ViewData["Title"] = "Outline";

#line default
#line hidden
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(42, 6196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef959c55b474591838632d6fd5d659b", async() => {
                BeginContext(48, 2333, true);
                WriteLiteral(@"

        <div class=""cent content"">
            <h2>Create Feature</h2>
            <h3 class =""green"">(PROJECT NAME)</h3>
            <h4>(FEATURE NAME)</h4>
            <hr>
        </div>
        

             <div class=""scenario-outline cent"" id=""create-scenario-outline-option"">
                    <h4>Create Scenario Outline</h4>
            </div>    


        <!---------steps to create a scenario outline---------------------->
            <div class=""scenario-outline steps-questions cent"" id=""s-outline"">

                    <div class=""dropdown"" id=""so-dropdown"">
                        <button class=""dropbtn"" onclick=""toogle_div('continue-btn');""><p>(Select Outline Step)</p><br>I want to:</button>
                        <div class=""dropdown-content"">
                            <button type=""button"" onclick=""toggle_div('so-user-is-on-page'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Go to Page</button><br>
                            <button type=""button"" onclick=""");
                WriteLiteral(@"toggle_div('so-user-login'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Log In</button><br>
                            <button type=""button"" onclick=""toggle_div('so-user-inputs'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Fill Out Form</button><br>
                            <button type=""button"" onclick=""toggle_div('so-check-element-contains'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Check Page for Content</button><br>
                            <button type=""button"" onclick=""toggle_div('so-user-clicks'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Click Link/Button</button><br>
                            <button type=""button"" onclick=""toggle_div('so-user-chooses-radio'); toggle_captions_visibility('so-caption-area');"" class=""dropdown-content"">Choose Radio Button</button><br>
                        </div> 
                    </div>    
            </div>

        <!-------------con");
                WriteLiteral(@"tinue to example steps------------------->

                <div class=""blank-area"" id=""so-caption-area"">                 
                    <div class=""cent"" id=""so-step-captions"">   
                        <div class=""hidden-div"" id=""so-user-is-on-page"">
                         ");
                EndContext();
                BeginContext(2381, 359, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094980bb3a604788bc4ed90520e00811", async() => {
                    BeginContext(2408, 325, true);
                    WriteLiteral(@"
                            <h5 >User is on (web) page.</h5>
                            <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(web address)"">
                            <button type=""button"" onclick=""toggle_div('so-user-is-on-page')"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2740, 129, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"so-user-login\">\n                            ");
                EndContext();
                BeginContext(2869, 511, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "078b522571984f0f9218f440a505705e", async() => {
                    BeginContext(2896, 477, true);
                    WriteLiteral(@"
                                <h5 >User logs in with (Username) and (Password).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Username)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Password)"">
                                <button type=""button"" onclick=""toggle_div('so-user-login') "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3380, 130, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"so-user-inputs\">\n                            ");
                EndContext();
                BeginContext(3510, 496, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2544f13eb684db693e90cf75f280db7", async() => {
                    BeginContext(3537, 462, true);
                    WriteLiteral(@"
                                <h5 >User inputs (Content) in (Field).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Conent)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Field)"">
                                <button type=""button"" onclick=""toggle_div('so-user-inputs') "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4006, 142, true);
                WriteLiteral("\n                        </div> \n\n                        <div class=\"hidden-div\" id=\"so-check-element-contains\">\n                            ");
                EndContext();
                BeginContext(4148, 513, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62d1b2273a004f98bda75445d014a387", async() => {
                    BeginContext(4175, 479, true);
                    WriteLiteral(@"
                                <h5 >Check that (Element) contains (Value).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Elment)"">
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(Value)"">
                                <button type=""button"" onclick=""toggle_div('so-check-element-contains'); "">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4661, 130, true);
                WriteLiteral("\n                        </div>\n\n                        <div class=\"hidden-div\" id=\"so-user-clicks\">\n                            ");
                EndContext();
                BeginContext(4791, 390, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee0db5acce94ae1950acfd6ee9207b0", async() => {
                    BeginContext(4818, 356, true);
                    WriteLiteral(@"
                                    <h5 >User clicks (link or button).</h5>
                                    <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(link or button)"">
                                    <button type=""button"" onclick=""toggle_div('so-user-clicks');"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5181, 138, true);
                WriteLiteral(" \n                        </div>\n\n                        <div class=\"hidden-div\" id=\"so-user-chooses-radio\">\n                            ");
                EndContext();
                BeginContext(5319, 382, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840cb57d16a34320847f3033f49b8323", async() => {
                    BeginContext(5346, 348, true);
                    WriteLiteral(@"
                                <h5 >User chooses (radio button).</h5>
                                <input type=""text"" name=""Feature_Details"" maxlength=""50"" size=""20"" placeholder=""(radio button)"">
                                <button type=""button"" onclick=""toggle_div('so-user-chooses-radio');"">Add Step</button>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5701, 530, true);
                WriteLiteral(@"
                        </div>

                    </div> 

                    
                    
                </div> 

                <br>
                <br>

                <div class=""cent"">
                        <a href=""/CreateFeature/Scenario"" class=""features-button"">Continue</a>    
                </div>
                <br>

                <div class=""cent"" id=""finish-link""><a href=""/CreateFeature/FinishedFile"" class=""finish-button"">FINISH FEATURE</a>
                        
                </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
