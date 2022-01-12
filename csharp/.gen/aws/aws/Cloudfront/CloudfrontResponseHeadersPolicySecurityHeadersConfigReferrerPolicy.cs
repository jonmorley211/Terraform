using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy")]
    public class CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy : aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object Override
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}.</summary>
        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReferrerPolicy
        {
            get;
            set;
        }
    }
}
