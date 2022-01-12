using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleActionCount), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionCount")]
    public interface IWafv2RuleGroupRuleActionCount
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_request_handling Wafv2RuleGroup#custom_request_handling}
        /// </remarks>
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCountCustomRequestHandling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleActionCountCustomRequestHandling? CustomRequestHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleActionCount), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionCount")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleActionCount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_request_handling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_request_handling Wafv2RuleGroup#custom_request_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCountCustomRequestHandling\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleActionCountCustomRequestHandling? CustomRequestHandling
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionCountCustomRequestHandling?>();
            }
        }
    }
}
