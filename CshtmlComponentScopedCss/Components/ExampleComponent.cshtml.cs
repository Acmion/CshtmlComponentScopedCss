using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acmion.CshtmlComponent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace CshtmlComponentScopedCss.Components
{
    [HtmlTargetElement("ExampleComponent")]
    public class ExampleComponent : CshtmlComponentBase
    {
        [HtmlAttributeName("Title")]
        public string Title { get; set; } = "";

        public ExampleComponent(IHtmlHelper htmlHelper) : base(htmlHelper, "/Components/ExampleComponent.cshtml", null)
        {
        }
    }
}
