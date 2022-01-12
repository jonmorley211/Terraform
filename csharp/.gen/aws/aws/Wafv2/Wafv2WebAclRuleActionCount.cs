using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleActionCount")]
    public class Wafv2WebAclRuleActionCount : aws.Wafv2.IWafv2WebAclRuleActionCount
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandling\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling? CustomRequestHandling
        {
            get;
            set;
        }
    }
}
