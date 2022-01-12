using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement")]
    public class Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement : aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#arn Wafv2WebAcl#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementNotStatementStatementOrStatementStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch
        {
            get;
            set;
        }
    }
}
