using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleActionBlockCustomResponse")]
    public class Wafv2WebAclRuleActionBlockCustomResponse : aws.Wafv2.IWafv2WebAclRuleActionBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_code Wafv2WebAcl#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response_body_key Wafv2WebAcl#custom_response_body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomResponseBodyKey
        {
            get;
            set;
        }

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#response_header Wafv2WebAcl#response_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleActionBlockCustomResponseResponseHeader[]? ResponseHeader
        {
            get;
            set;
        }
    }
}
