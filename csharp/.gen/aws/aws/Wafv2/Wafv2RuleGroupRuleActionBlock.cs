using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleActionBlock")]
    public class Wafv2RuleGroupRuleActionBlock : aws.Wafv2.IWafv2RuleGroupRuleActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_response Wafv2RuleGroup#custom_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponse
        {
            get;
            set;
        }
    }
}
