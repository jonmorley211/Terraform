using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions")]
    public class NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#rule_order NetworkfirewallRuleGroup#rule_order}.</summary>
        [JsiiProperty(name: "ruleOrder", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleOrder
        {
            get;
            set;
        }
    }
}
