using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRule")]
    public class Wafv2RuleGroupRule : aws.Wafv2.IWafv2RuleGroupRule
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#action Wafv2RuleGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleAction\"}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleAction Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#name Wafv2RuleGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#priority Wafv2RuleGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#statement Wafv2RuleGroup#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatement\"}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatement Statement
        {
            get;
            set;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#visibility_config Wafv2RuleGroup#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleVisibilityConfig\"}", isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleVisibilityConfig VisibilityConfig
        {
            get;
            set;
        }

        /// <summary>rule_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#rule_label Wafv2RuleGroup#rule_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleLabel", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleRuleLabel\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleRuleLabel[]? RuleLabel
        {
            get;
            set;
        }
    }
}
