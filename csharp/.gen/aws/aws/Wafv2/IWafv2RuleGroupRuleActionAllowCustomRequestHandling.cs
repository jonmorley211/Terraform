using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandling")]
    public interface IWafv2RuleGroupRuleActionAllowCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#insert_header Wafv2RuleGroup#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandling")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>insert_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#insert_header Wafv2RuleGroup#insert_header}
            /// </remarks>
            [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionAllowCustomRequestHandlingInsertHeader[]>()!;
            }
        }
    }
}
