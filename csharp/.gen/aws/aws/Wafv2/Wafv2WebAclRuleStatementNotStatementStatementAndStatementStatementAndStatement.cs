using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement : aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementAndStatementStatement[] Statement
        {
            get;
            set;
        }
    }
}
