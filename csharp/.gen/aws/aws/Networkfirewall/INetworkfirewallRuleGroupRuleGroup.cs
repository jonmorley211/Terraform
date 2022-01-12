using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroup), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroup")]
    public interface INetworkfirewallRuleGroupRuleGroup
    {
        /// <summary>rules_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
        /// </remarks>
        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}")]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
        {
            get;
        }

        /// <summary>rule_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
        /// </remarks>
        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>stateful_rule_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
        /// </remarks>
        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroup), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rules_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rules_source NetworkfirewallRuleGroup#rules_source}
            /// </remarks>
            [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}")]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource RulesSource
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource>()!;
            }

            /// <summary>rule_variables block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_variables NetworkfirewallRuleGroup#rule_variables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariables
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables?>();
            }

            /// <summary>stateful_rule_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#stateful_rule_options NetworkfirewallRuleGroup#stateful_rule_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptions
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions?>();
            }
        }
    }
}
