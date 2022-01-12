using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleRuleOption")]
    public class NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleRuleOption : aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRuleRuleOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#keyword NetworkfirewallRuleGroup#keyword}.</summary>
        [JsiiProperty(name: "keyword", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Keyword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#settings NetworkfirewallRuleGroup#settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Settings
        {
            get;
            set;
        }
    }
}
