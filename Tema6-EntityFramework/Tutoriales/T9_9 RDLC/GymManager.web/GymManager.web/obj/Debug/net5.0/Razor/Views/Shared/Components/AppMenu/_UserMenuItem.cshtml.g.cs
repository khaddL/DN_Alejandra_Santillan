#pragma checksum "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9365430245ec3520ca253f732a50250ab5046d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9365430245ec3520ca253f732a50250ab5046d9e", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.web.Models.UserMenuItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  
    var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x => x.Order);


#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if (Model.MenuItem.Items.Count < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n           <a class=\"nav-link\" ");
#nullable restore
#line 13 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                           Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral(" \" ");
#nullable restore
#line 13 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                    Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current= \"page\"" : " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("\"  href=\"#\">");
#nullable restore
#line 13 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                                     Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n");
#nullable restore
#line 15 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"

}

else 
{

    string currentElementId = "menu-" + new Random().Next();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 622, "\"", 725, 3);
            WriteAttributeValue("", 630, "nav-link", 630, 8, true);
            WriteAttributeValue(" ", 638, "dropdown-toggle", 639, 16, true);
#nullable restore
#line 24 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 654, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : " ", 655, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 735, "\"", 757, 1);
#nullable restore
#line 24 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 740, currentElementId, 740, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
#nullable restore
#line 24 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                              Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 873, "\"", 908, 1);
#nullable restore
#line 25 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 891, currentElementId, 891, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 27 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
             foreach(var subMenu in Model.MenuItem.Items)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1050, "\"", 1069, 1);
#nullable restore
#line 30 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1057, subMenu.Url, 1057, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                            Write(subMenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 31 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </li>\r\n");
#nullable restore
#line 37 "D:\Mis Proyectos\Punto Singular\ASP Entity Framework\Tutoriales\T9_9 RDLC\GymManager.web\GymManager.web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.web.Models.UserMenuItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
