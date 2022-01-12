using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementXssMatchStatementFieldToMatch?>();
            }
        }
    }
}
