using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
        {
            get;
            set;
        }
    }
}
