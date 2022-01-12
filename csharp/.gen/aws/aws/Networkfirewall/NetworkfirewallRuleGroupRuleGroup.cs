using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroup")]
    public class NetworkfirewallRuleGroupRuleGroup : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroup
    {
        /// <summary>rules_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
        /// </remarks>
        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}", isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
        {
            get;
            set;
        }

        /// <summary>rule_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
        {
            get;
            set;
        }

        /// <summary>stateful_rule_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
        {
            get;
            set;
        }
    }
}
