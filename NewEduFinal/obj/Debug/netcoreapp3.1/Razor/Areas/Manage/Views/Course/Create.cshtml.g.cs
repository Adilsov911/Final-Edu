#pragma checksum "C:\Users\adils\OneDrive\Рабочий стол\NewEduFinal\NewEduFinal\Areas\Manage\Views\Course\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac17a4a84ee6764ce54d4f5b22f66fb57498537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Course_Create), @"mvc.1.0.view", @"/Areas/Manage/Views/Course/Create.cshtml")]
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
#line 2 "C:\Users\adils\OneDrive\Рабочий стол\NewEduFinal\NewEduFinal\Areas\Manage\Views\_ViewImports.cshtml"
using NewEduFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adils\OneDrive\Рабочий стол\NewEduFinal\NewEduFinal\Areas\Manage\Views\_ViewImports.cshtml"
using NewEduFinal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adils\OneDrive\Рабочий стол\NewEduFinal\NewEduFinal\Areas\Manage\Views\_ViewImports.cshtml"
using NewEduFinal.Areas.Manage.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac17a4a84ee6764ce54d4f5b22f66fb57498537", @"/Areas/Manage/Views/Course/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f646dc1f1675de08b3eb041f2d4058cfec0efc41", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Course_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--\n\n\n<h1 class=\"h3 mb-4 text-gray-800\">Create Brand</h1>\n<div class=\"row justify-content-center\">\n    <div class=\"col-lg-8\">\n        <form method=\"post\" enctype=\"multipart/form-data\">-->\n\n\n");
            WriteLiteral("            <!--<div class=\"form-group\">\n                <label--> ");
            WriteLiteral("<!-->Course Name</label>\n                <textarea--> ");
            WriteLiteral(" <!--class=\"form-control\" id=\"CourseName\" rows=\"3\"></textarea>\n                <span--> ");
            WriteLiteral(" <!--class=\"text-danger\"></span>\n            </div>-->\n");
            WriteLiteral("            <!--<div class=\"form-group\">\n                <label asp-for=\"\">Description</label>\n                <textarea--> ");
            WriteLiteral(@" <!--class=""form-control"" id=""Description"" rows=""3""></textarea>
                <span asp-validation-for="""" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for="""">About</label>
                <input asp-for="""" class=""form-control col-md-2"" id=""AboutCourseInfo"" rows=""3"">
                <span asp-validation-for="""" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for="""">HowToApply</label>
                <input asp-for="""" class=""form-control col-md-2"" id=""HowToApplyInfo"" rows=""3"">
                <span asp-validation-for="""" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for="""">Certification</label>
                <input asp-for="""" class=""form-control col-md-2"" id=""CertificationInfo"" rows=""3"">
                <span asp-validation-for="""" class=""text-danger""></span>
            </div>
            <div class=""form-group col-md-");
            WriteLiteral(@"3"">
                <label asp-for="""">Category</label>
                <select class=""form-control"" asp-for="""" asp-items="""">
                </select>
            </div>

            <div class=""form-group col-md-3"">
                <label asp-for="""">Tags</label>
                <select class=""form-control"" asp-for="""" asp-items="")"">
                </select>
            </div>
            <div class=""form-group"">
                <label asp-for="""">ImageFile</label>
                <input asp-for="""" accept=""image/*"" class=""form-control col-md-2"" rows=""3"">
                <span asp-validation-for="""" class=""text-danger""></span>
            </div>

            <button type=""submit"" class=""btn btn-primary"">Create</button>
        </form>
    </div>
</div>-->");
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
