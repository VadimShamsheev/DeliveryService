using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;

namespace DeliveryService.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "authorize-visible")]
    public class VisibleWithAuthorizeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.Attributes.SetAttribute("style", "visibility: hidden;");
        }
    }
}
