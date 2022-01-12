using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementIpSetReferenceStatement")]
    public class Wafv2RuleGroupRuleStatementOrStatementStatementIpSetReferenceStatement : aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementIpSetReferenceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#arn Wafv2RuleGroup#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>ip_set_forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#ip_set_forwarded_ip_config Wafv2RuleGroup#ip_set_forwarded_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSetForwardedIpConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementStatementIpSetReferenceStatementIpSetForwardedIpConfig\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatementStatementIpSetReferenceStatementIpSetForwardedIpConfig? IpSetForwardedIpConfig
        {
            get;
            set;
        }
    }
}
