#pragma checksum "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e87e2f1d478dcb97f5be06dbb0c01d101ebbac9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Show), @"mvc.1.0.view", @"/Views/Albums/Show.cshtml")]
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
#line 9 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
using Catalogue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e87e2f1d478dcb97f5be06dbb0c01d101ebbac9", @"/Views/Albums/Show.cshtml")]
    public class Views_Albums_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e87e2f1d478dcb97f5be06dbb0c01d101ebbac92872", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>My To-Do List!</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e87e2f1d478dcb97f5be06dbb0c01d101ebbac94111", async() => {
                WriteLiteral("\n");
                WriteLiteral("\n    <h3>Here are all the songs in this album:</h3>\n\n    <ol>\n");
#nullable restore
#line 14 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
     foreach (Song song in @Model["songs"])
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <li><a");
                BeginWriteAttribute("href", " href=\'", 481, "\'", 529, 4);
                WriteAttributeValue("", 488, "/albums/", 488, 8, true);
#nullable restore
#line 16 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
WriteAttributeValue("", 496, Model["album"].Id, 496, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 514, "/songs/", 514, 7, true);
#nullable restore
#line 16 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
WriteAttributeValue("", 521, song.Id, 521, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 16 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
                                                         Write(song.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\n");
#nullable restore
#line 17 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ol>\n\n    <p><a");
                BeginWriteAttribute("href", " href=\'", 584, "\'", 627, 3);
                WriteAttributeValue("", 591, "/albums/", 591, 8, true);
#nullable restore
#line 20 "/Users/mherbert/Desktop/Music-Catalogue/Catalogue.Solution/Catalogue/Views/Albums/Show.cshtml"
WriteAttributeValue("", 599, Model["album"].Id, 599, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 617, "/songs/new", 617, 10, true);
                EndWriteAttribute();
                WriteLiteral(">Add a new Song</a></p>\n    <p><a href=\'/albums\'>Return to album list</a></p>\n    <p><a href=\'/\'>Return to Main Page</a></p>\n  ");
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
            WriteLiteral("\n</html>");
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