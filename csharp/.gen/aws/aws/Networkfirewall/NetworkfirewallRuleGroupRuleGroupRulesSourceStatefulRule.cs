using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule")]
    public class NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#action NetworkfirewallRuleGroup#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Action
        {
            get;
            set;
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#header NetworkfirewallRuleGroup#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleHeader\"}", isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleHeader Header
        {
            get;
            set;
        }

        /// <summary>rule_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_option NetworkfirewallRuleGroup#rule_option}
        /// </remarks>
        [JsiiProperty(name: "ruleOption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleRuleOption\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleRuleOption[] RuleOption
        {
            get;
            set;
        }
    }
}
