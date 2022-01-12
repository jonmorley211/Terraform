using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet")]
    public class NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSetsIpSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#definition NetworkfirewallRuleGroup#definition}.</summary>
        [JsiiProperty(name: "definition", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Definition
        {
            get;
            set;
        }
    }
}
