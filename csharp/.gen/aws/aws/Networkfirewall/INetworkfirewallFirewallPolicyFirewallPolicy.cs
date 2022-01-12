using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicy), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicy")]
    public interface INetworkfirewallFirewallPolicyFirewallPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_default_actions NetworkfirewallFirewallPolicy#stateless_default_actions}.</summary>
        [JsiiProperty(name: "statelessDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] StatelessDefaultActions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_fragment_default_actions NetworkfirewallFirewallPolicy#stateless_fragment_default_actions}.</summary>
        [JsiiProperty(name: "statelessFragmentDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] StatelessFragmentDefaultActions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_default_actions NetworkfirewallFirewallPolicy#stateful_default_actions}.</summary>
        [JsiiProperty(name: "statefulDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StatefulDefaultActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateful_engine_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_engine_options NetworkfirewallFirewallPolicy#stateful_engine_options}
        /// </remarks>
        [JsiiProperty(name: "statefulEngineOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions? StatefulEngineOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateful_rule_group_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_rule_group_reference NetworkfirewallFirewallPolicy#stateful_rule_group_reference}
        /// </remarks>
        [JsiiProperty(name: "statefulRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]? StatefulRuleGroupReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateless_custom_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_custom_action NetworkfirewallFirewallPolicy#stateless_custom_action}
        /// </remarks>
        [JsiiProperty(name: "statelessCustomAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]? StatelessCustomAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateless_rule_group_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_rule_group_reference NetworkfirewallFirewallPolicy#stateless_rule_group_reference}
        /// </remarks>
        [JsiiProperty(name: "statelessRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]? StatelessRuleGroupReference
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicy), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_default_actions NetworkfirewallFirewallPolicy#stateless_default_actions}.</summary>
            [JsiiProperty(name: "statelessDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] StatelessDefaultActions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_fragment_default_actions NetworkfirewallFirewallPolicy#stateless_fragment_default_actions}.</summary>
            [JsiiProperty(name: "statelessFragmentDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] StatelessFragmentDefaultActions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_default_actions NetworkfirewallFirewallPolicy#stateful_default_actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "statefulDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StatefulDefaultActions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>stateful_engine_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_engine_options NetworkfirewallFirewallPolicy#stateful_engine_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statefulEngineOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions\"}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions? StatefulEngineOptions
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions?>();
            }

            /// <summary>stateful_rule_group_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateful_rule_group_reference NetworkfirewallFirewallPolicy#stateful_rule_group_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statefulRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]? StatefulRuleGroupReference
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]?>();
            }

            /// <summary>stateless_custom_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_custom_action NetworkfirewallFirewallPolicy#stateless_custom_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statelessCustomAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]? StatelessCustomAction
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]?>();
            }

            /// <summary>stateless_rule_group_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#stateless_rule_group_reference NetworkfirewallFirewallPolicy#stateless_rule_group_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statelessRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]? StatelessRuleGroupReference
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]?>();
            }
        }
    }
}
