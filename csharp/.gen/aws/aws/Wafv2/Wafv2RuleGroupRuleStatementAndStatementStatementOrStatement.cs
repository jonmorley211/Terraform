using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement")]
    public class Wafv2RuleGroupRuleStatementAndStatementStatementOrStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatementStatementOrStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
