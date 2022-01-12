using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement")]
    public interface IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
            /// </remarks>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch?>();
            }
        }
    }
}
