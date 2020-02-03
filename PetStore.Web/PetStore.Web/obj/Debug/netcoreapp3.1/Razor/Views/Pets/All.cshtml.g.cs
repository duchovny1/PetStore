#pragma checksum "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3c015ac3d63dcdc2e4532a6a288e7795991202"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_All), @"mvc.1.0.view", @"/Views/Pets/All.cshtml")]
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
#line 1 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\_ViewImports.cshtml"
using PetStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\_ViewImports.cshtml"
using PetStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
using PetStore.Web.Models.Pets;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3c015ac3d63dcdc2e4532a6a288e7795991202", @"/Views/Pets/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f87c14bbcb83320c5b954b808f080ef4b68fda", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllPetsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h1>All</h1>\r\n\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 93, "\"", 134, 2);
            WriteAttributeValue("", 100, "/Pets/All?page=", 100, 15, true);
#nullable restore
#line 9 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
WriteAttributeValue("", 115, Model.PreviousPage, 115, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 135, "\"", 220, 4);
            WriteAttributeValue("", 143, "float-left", 143, 10, true);
            WriteAttributeValue(" ", 153, "btn", 154, 4, true);
            WriteAttributeValue(" ", 157, "btn-info", 158, 9, true);
#nullable restore
#line 9 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
WriteAttributeValue(" ", 166, Model.PreviousDisabled ? "disabled" : string.Empty, 167, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prev</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 238, "\"", 275, 2);
            WriteAttributeValue("", 245, "/Pets/All?page=", 245, 15, true);
#nullable restore
#line 10 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
WriteAttributeValue("", 260, Model.NextPage, 260, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 276, "\"", 357, 4);
            WriteAttributeValue("", 284, "float-right", 284, 11, true);
            WriteAttributeValue(" ", 295, "btn", 296, 4, true);
            WriteAttributeValue(" ", 299, "btn-info", 300, 9, true);
#nullable restore
#line 10 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
WriteAttributeValue("", 308, Model.NextDisabled ? "disabled" : string.Empty, 308, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Next</a>
</div>

<br />
<br />

<table class=""table table-bordered table-striped"">
    <tr>
        <th>
            Type
        </th>
        <th>
            Breed
        </th>
        <th>
            Price
        </th>
    </tr>
</table>

");
#nullable restore
#line 30 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
 foreach (var pet in Model.Pets)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 34 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
       Write(pet.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 37 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
       Write(pet.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            $");
#nullable restore
#line 40 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
        Write(pet.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href = \"", 863, "\"", 892, 2);
            WriteAttributeValue("", 872, "/Pets/Delete/", 872, 13, true);
#nullable restore
#line 43 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
WriteAttributeValue("", 885, pet.Id, 885, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class =\"btn btn-danger btn-small\">Delete</a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 46 "C:\Repos\PetStore\PetStore.Web\PetStore.Web\Views\Pets\All.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Hello from pets!</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllPetsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
