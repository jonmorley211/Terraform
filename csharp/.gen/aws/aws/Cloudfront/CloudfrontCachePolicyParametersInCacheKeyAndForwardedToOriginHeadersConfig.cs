using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig : aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#header_behavior CloudfrontCachePolicy#header_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HeaderBehavior
        {
            get;
            set;
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#headers CloudfrontCachePolicy#headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers
        {
            get;
            set;
        }
    }
}
