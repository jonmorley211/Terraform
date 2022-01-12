using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions")]
    public interface INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_order NetworkfirewallRuleGroup#rule_order}.</summary>
        [JsiiProperty(name: "ruleOrder", typeJson: "{\"primitive\":\"string\"}")]
        string RuleOrder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_order NetworkfirewallRuleGroup#rule_order}.</summary>
            [JsiiProperty(name: "ruleOrder", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleOrder
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
