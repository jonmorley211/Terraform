using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy")]
    public class CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy : aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}.</summary>
        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ContentSecurityPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object Override
        {
            get;
            set;
        }
    }
}
