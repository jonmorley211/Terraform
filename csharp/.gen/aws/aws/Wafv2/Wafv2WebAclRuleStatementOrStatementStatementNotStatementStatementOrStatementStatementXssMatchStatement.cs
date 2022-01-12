using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement : aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatement
    {
        /// <summary>text_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#text_transformation Wafv2WebAcl#text_transformation}
        /// </remarks>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatementTextTransformation[] TextTransformation
        {
            get;
            set;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#field_to_match Wafv2WebAcl#field_to_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementXssMatchStatementFieldToMatch? FieldToMatch
        {
            get;
            set;
        }
    }
}
