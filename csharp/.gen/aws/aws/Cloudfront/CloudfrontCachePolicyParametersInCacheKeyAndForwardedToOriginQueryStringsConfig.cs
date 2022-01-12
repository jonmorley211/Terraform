using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig : aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_string_behavior CloudfrontCachePolicy#query_string_behavior}.</summary>
        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string QueryStringBehavior
        {
            get;
            set;
        }

        /// <summary>query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_strings CloudfrontCachePolicy#query_strings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings
        {
            get;
            set;
        }
    }
}
