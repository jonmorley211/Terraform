using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction")]
    public interface INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
    {
        /// <summary>action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#action_definition NetworkfirewallRuleGroup#action_definition}
        /// </remarks>
        [JsiiProperty(name: "actionDefinition", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition\"}")]
        aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition ActionDefinition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#action_name NetworkfirewallRuleGroup#action_name}.</summary>
        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
        string ActionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#action_definition NetworkfirewallRuleGroup#action_definition}
            /// </remarks>
            [JsiiProperty(name: "actionDefinition", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition\"}")]
            public aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition ActionDefinition
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_rule_group#action_name NetworkfirewallRuleGroup#action_name}.</summary>
            [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
