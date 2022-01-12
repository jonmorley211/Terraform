using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference : aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#priority NetworkfirewallFirewallPolicy#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#resource_arn NetworkfirewallFirewallPolicy#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResourceArn
        {
            get;
            set;
        }
    }
}
