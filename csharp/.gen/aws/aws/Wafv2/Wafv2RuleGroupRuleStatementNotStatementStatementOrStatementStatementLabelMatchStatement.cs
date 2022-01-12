using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementLabelMatchStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementLabelMatchStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementLabelMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#key Wafv2RuleGroup#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#scope Wafv2RuleGroup#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Scope
        {
            get;
            set;
        }
    }
}
