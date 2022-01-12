using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource")]
    public class NetworkfirewallRuleGroupRuleGroupRulesSource : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource
    {
        /// <summary>rules_source_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rules_source_list NetworkfirewallRuleGroup#rules_source_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rulesSourceList", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList\"}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList? RulesSourceList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rules_string NetworkfirewallRuleGroup#rules_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rulesString", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RulesString
        {
            get;
            set;
        }

        /// <summary>stateful_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateful_rule NetworkfirewallRuleGroup#stateful_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statefulRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule[]? StatefulRule
        {
            get;
            set;
        }

        /// <summary>stateless_rules_and_custom_actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateless_rules_and_custom_actions NetworkfirewallRuleGroup#stateless_rules_and_custom_actions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statelessRulesAndCustomActions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions\"}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions
        {
            get;
            set;
        }
    }
}
