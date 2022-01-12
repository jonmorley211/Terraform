using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#arn Wafv2WebAcl#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#arn Wafv2WebAcl#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch?>();
            }
        }
    }
}
