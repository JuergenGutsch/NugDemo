using Microsoft.AspNet.Razor.TagHelpers;

namespace Demo.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string _emailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />. 
        // Pascal case gets translated into lower-kebab-case.
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            var address = MailTo + "@" + _emailDomain;
            output.Attributes["href"] = "mailto:" + address;
            output.Content.SetContent(address);
        }
    }
}
