using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleActionAllow")]
    public class Wafv2RuleGroupRuleActionAllow : aws.Wafv2.IWafv2RuleGroupRuleActionAllow
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_request_handling Wafv2RuleGroup#custom_request_handling}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandling\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandling? CustomRequestHandling
        {
            get;
            set;
        }
    }
}
