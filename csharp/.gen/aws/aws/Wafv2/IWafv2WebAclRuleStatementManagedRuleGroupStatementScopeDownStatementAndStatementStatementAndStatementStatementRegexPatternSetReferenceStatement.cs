using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement
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
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatement
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
            [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementTextTransformation[]>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementStatementAndStatementStatementRegexPatternSetReferenceStatementFieldToMatch?>();
            }
        }
    }
}
