using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleActionBlock), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionBlock")]
    public interface IWafv2RuleGroupRuleActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_response Wafv2RuleGroup#custom_response}
        /// </remarks>
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleActionBlock), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionBlock")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleActionBlock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_response Wafv2RuleGroup#custom_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponse
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse?>();
            }
        }
    }
}
