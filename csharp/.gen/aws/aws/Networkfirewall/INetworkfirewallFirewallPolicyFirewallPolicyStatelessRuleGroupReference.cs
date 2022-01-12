using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference")]
    public interface INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#priority NetworkfirewallFirewallPolicy#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#resource_arn NetworkfirewallFirewallPolicy#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#priority NetworkfirewallFirewallPolicy#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#resource_arn NetworkfirewallFirewallPolicy#resource_arn}.</summary>
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
