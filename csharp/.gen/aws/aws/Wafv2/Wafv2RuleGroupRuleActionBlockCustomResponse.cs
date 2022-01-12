using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse")]
    public class Wafv2RuleGroupRuleActionBlockCustomResponse : aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#response_code Wafv2RuleGroup#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#custom_response_body_key Wafv2RuleGroup#custom_response_body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomResponseBodyKey
        {
            get;
            set;
        }

        /// <summary>response_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_rule_group#response_header Wafv2RuleGroup#response_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[]? ResponseHeader
        {
            get;
            set;
        }
    }
}
