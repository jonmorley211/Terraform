using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicy")]
    public class NetworkfirewallFirewallPolicyFirewallPolicy : aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_default_actions NetworkfirewallFirewallPolicy#stateless_default_actions}.</summary>
        [JsiiProperty(name: "statelessDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] StatelessDefaultActions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_fragment_default_actions NetworkfirewallFirewallPolicy#stateless_fragment_default_actions}.</summary>
        [JsiiProperty(name: "statelessFragmentDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] StatelessFragmentDefaultActions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_default_actions NetworkfirewallFirewallPolicy#stateful_default_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statefulDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? StatefulDefaultActions
        {
            get;
            set;
        }

        /// <summary>stateful_engine_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_engine_options NetworkfirewallFirewallPolicy#stateful_engine_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statefulEngineOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions\"}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions? StatefulEngineOptions
        {
            get;
            set;
        }

        /// <summary>stateful_rule_group_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_rule_group_reference NetworkfirewallFirewallPolicy#stateful_rule_group_reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]? StatefulRuleGroupReference
        {
            get;
            set;
        }

        /// <summary>stateless_custom_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_custom_action NetworkfirewallFirewallPolicy#stateless_custom_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statelessCustomAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]? StatelessCustomAction
        {
            get;
            set;
        }

        /// <summary>stateless_rule_group_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_rule_group_reference NetworkfirewallFirewallPolicy#stateless_rule_group_reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statelessRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]? StatelessRuleGroupReference
        {
            get;
            set;
        }
    }
}
