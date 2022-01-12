using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch?>();
            }
        }
    }
}
