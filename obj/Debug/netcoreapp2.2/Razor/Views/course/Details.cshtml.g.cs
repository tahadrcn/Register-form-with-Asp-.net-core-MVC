#pragma checksum "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74ac2f28e09317caba5af8fdeefd9d07532eaeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_course_Details), @"mvc.1.0.view", @"/Views/course/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/course/Details.cshtml", typeof(AspNetCore.Views_course_Details))]
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
#line 1 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\_ViewImports.cshtml"
using courseapp.Models;

#line default
#line hidden
#line 2 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\_ViewImports.cshtml"
using courseapp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74ac2f28e09317caba5af8fdeefd9d07532eaeb", @"/Views/course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468f49048d3639467cae3f37dad62768850ad8c6", @"/Views/_ViewImports.cshtml")]
    public class Views_course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseStudentViewModel>
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
#line 2 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
  
  var classname=Model.Students.Count > 2 ? "popular": null ;

#line default
#line hidden
            BeginContext(100, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            EndContext();
            BeginContext(137, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f74ac2f28e09317caba5af8fdeefd9d07532eaeb3675", async() => {
                BeginContext(143, 233, true);
                WriteLiteral("\r\n    <title>web sayfam</title>\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n  ");
                EndContext();
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
            EndContext();
            BeginContext(383, 97, true);
            WriteLiteral("\r\n  <style>\r\n    .popular{\r\n      color: green;\r\n      font-weight: 200px;\r\n    }\r\n  </style>\r\n  ");
            EndContext();
            BeginContext(480, 319, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f74ac2f28e09317caba5af8fdeefd9d07532eaeb5217", async() => {
                BeginContext(486, 9, true);
                WriteLiteral("\r\n    <h2");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 495, "\"", 513, 1);
#line 21 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
WriteAttributeValue("", 503, classname, 503, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(514, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(516, 17, false);
#line 21 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
                      Write(Model.Course.name);

#line default
#line hidden
                EndContext();
                BeginContext(533, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 22 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
     if (@Model.Students.Count==0)
    {
      

#line default
#line hidden
                BeginContext(595, 17, true);
                WriteLiteral("Katılımcı yoktur.");
                EndContext();
#line 24 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
                                    
    }
    else{

#line default
#line hidden
                BeginContext(639, 13, true);
                WriteLiteral("      <ul> \r\n");
                EndContext();
#line 28 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
       foreach (var item in Model.Students)
      {

#line default
#line hidden
                BeginContext(706, 22, true);
                WriteLiteral("       <li>\r\n         ");
                EndContext();
                BeginContext(729, 10, false);
#line 31 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
    Write(item.names);

#line default
#line hidden
                EndContext();
                BeginContext(739, 18, true);
                WriteLiteral("\r\n         </li>\r\n");
                EndContext();
#line 33 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
      }

#line default
#line hidden
                BeginContext(766, 11, true);
                WriteLiteral("    </ul>\r\n");
                EndContext();
#line 35 "C:\Users\TahaDirican\Source\Repos\courseapp\courseapp\Views\course\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(784, 8, true);
                WriteLiteral("    \r\n  ");
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
            BeginContext(799, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseStudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
