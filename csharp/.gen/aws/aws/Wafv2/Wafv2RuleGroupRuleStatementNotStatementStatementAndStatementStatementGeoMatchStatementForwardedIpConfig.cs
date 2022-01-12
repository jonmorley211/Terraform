using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementAndStatementStatementGeoMatchStatementForwardedIpConfig")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementAndStatementStatementGeoMatchStatementForwardedIpConfig : aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementAndStatementStatementGeoMatchStatementForwardedIpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#fallback_behavior Wafv2RuleGroup#fallback_behavior}.</summary>
        [JsiiProperty(name: "fallbackBehavior", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FallbackBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#header_name Wafv2RuleGroup#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HeaderName
        {
            get;
            set;
        }
    }
}
