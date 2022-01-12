using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfig")]
    public class CloudfrontResponseHeadersPolicyCustomHeadersConfig : aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#items CloudfrontResponseHeadersPolicy#items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigItems\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfigItems[]? Items
        {
            get;
            set;
        }
    }
}
