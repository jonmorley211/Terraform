using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction : aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction
    {
        /// <summary>action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#action_definition NetworkfirewallFirewallPolicy#action_definition}
        /// </remarks>
        [JsiiProperty(name: "actionDefinition", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomActionActionDefinition\"}", isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomActionActionDefinition ActionDefinition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_firewall_policy#action_name NetworkfirewallFirewallPolicy#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ActionName
        {
            get;
            set;
        }
    }
}
