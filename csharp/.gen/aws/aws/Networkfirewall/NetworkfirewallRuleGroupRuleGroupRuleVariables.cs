using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables")]
    public class NetworkfirewallRuleGroupRuleGroupRuleVariables : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables
    {
        /// <summary>ip_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#ip_sets NetworkfirewallRuleGroup#ip_sets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]? IpSets
        {
            get;
            set;
        }

        /// <summary>port_sets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#port_sets NetworkfirewallRuleGroup#port_sets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]? PortSets
        {
            get;
            set;
        }
    }
}
