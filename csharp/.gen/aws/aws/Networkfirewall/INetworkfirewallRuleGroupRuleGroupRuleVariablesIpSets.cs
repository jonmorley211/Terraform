using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets")]
    public interface INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets
    {
        /// <summary>ip_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#ip_set NetworkfirewallRuleGroup#ip_set}
        /// </remarks>
        [JsiiProperty(name: "ipSet", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet\"}")]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet IpSet
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#key NetworkfirewallRuleGroup#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ip_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#ip_set NetworkfirewallRuleGroup#ip_set}
            /// </remarks>
            [JsiiProperty(name: "ipSet", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet\"}")]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet IpSet
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#key NetworkfirewallRuleGroup#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
