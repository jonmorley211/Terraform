using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandling")]
    public class Wafv2RuleGroupRuleActionAllowCustomRequestHandling : aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#insert_header Wafv2RuleGroup#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get;
            set;
        }
    }
}
