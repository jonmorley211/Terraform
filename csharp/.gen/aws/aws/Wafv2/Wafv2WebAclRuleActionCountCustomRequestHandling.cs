using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandling")]
    public class Wafv2WebAclRuleActionCountCustomRequestHandling : aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get;
            set;
        }
    }
}
