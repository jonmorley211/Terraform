using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement")]
    public interface IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#arn Wafv2RuleGroup#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#arn Wafv2RuleGroup#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#text_transformation Wafv2RuleGroup#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#field_to_match Wafv2RuleGroup#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch?>();
            }
        }
    }
}
