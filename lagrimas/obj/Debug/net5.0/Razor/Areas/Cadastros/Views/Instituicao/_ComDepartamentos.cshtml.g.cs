#pragma checksum "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93ee7f0778d3c58357b2346bbbf05302a94476b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cadastros_Views_Instituicao__ComDepartamentos), @"mvc.1.0.view", @"/Areas/Cadastros/Views/Instituicao/_ComDepartamentos.cshtml")]
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
#line 1 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\_ViewImports.cshtml"
using lagrimas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\_ViewImports.cshtml"
using lagrimas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93ee7f0778d3c58357b2346bbbf05302a94476b", @"/Areas/Cadastros/Views/Instituicao/_ComDepartamentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35107be532056268993734c19d27f9cff0ab371e", @"/Areas/Cadastros/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Cadastros_Views_Instituicao__ComDepartamentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Modelo.Cadastros.Departamento>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card-block"">
    <div class=""card-header text-white badge-warning text-center"">Departamentos Registrados na Instituição</div>
    <div class=""card-body"">
        <table>
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 10 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                   Write(Html.DisplayNameFor(model => model.Instituicao.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 15 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 19 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 22 "D:\AspNet\AspNet\lagrimas\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Modelo.Cadastros.Departamento>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
