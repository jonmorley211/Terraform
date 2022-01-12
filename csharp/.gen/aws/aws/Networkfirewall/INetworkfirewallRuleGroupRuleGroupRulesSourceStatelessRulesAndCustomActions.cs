using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions")]
    public interface INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions
    {
        /// <summary>stateless_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateless_rule NetworkfirewallRuleGroup#stateless_rule}
        /// </remarks>
        [JsiiProperty(name: "statelessRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule\"},\"kind\":\"array\"}}")]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule[] StatelessRule
        {
            get;
        }

        /// <summary>custom_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#custom_action NetworkfirewallRuleGroup#custom_action}
        /// </remarks>
        [JsiiProperty(name: "customAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction[]? CustomAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>stateless_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateless_rule NetworkfirewallRuleGroup#stateless_rule}
            /// </remarks>
            [JsiiProperty(name: "statelessRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule\"},\"kind\":\"array\"}}")]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule[] StatelessRule
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule[]>()!;
            }

            /// <summary>custom_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#custom_action NetworkfirewallRuleGroup#custom_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction[]? CustomAction
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction[]?>();
            }
        }
    }
}
