using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementGeoMatchStatement")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementGeoMatchStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#country_codes Wafv2RuleGroup#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CountryCodes
        {
            get;
            set;
        }

        /// <summary>forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#forwarded_ip_config Wafv2RuleGroup#forwarded_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementGeoMatchStatementForwardedIpConfig\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementGeoMatchStatementForwardedIpConfig? ForwardedIpConfig
        {
            get;
            set;
        }
    }
}
