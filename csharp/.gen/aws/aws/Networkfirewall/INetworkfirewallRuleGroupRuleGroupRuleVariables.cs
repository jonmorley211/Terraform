using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariables), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables")]
    public interface INetworkfirewallRuleGroupRuleGroupRuleVariables
    {
        /// <summary>ip_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#ip_sets NetworkfirewallRuleGroup#ip_sets}
        /// </remarks>
        [JsiiProperty(name: "ipSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]? IpSets
        {
            get
            {
                return null;
            }
        }

        /// <summary>port_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#port_sets NetworkfirewallRuleGroup#port_sets}
        /// </remarks>
        [JsiiProperty(name: "portSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]? PortSets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariables), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ip_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#ip_sets NetworkfirewallRuleGroup#ip_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]? IpSets
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]?>();
            }

            /// <summary>port_sets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#port_sets NetworkfirewallRuleGroup#port_sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]? PortSets
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]?>();
            }
        }
    }
}
