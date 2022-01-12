using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclDefaultActionBlock")]
    public class Wafv2WebAclDefaultActionBlock : aws.Wafv2.IWafv2WebAclDefaultActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response Wafv2WebAcl#custom_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponse\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponse? CustomResponse
        {
            get;
            set;
        }
    }
}
