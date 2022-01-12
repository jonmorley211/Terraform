using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin : aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin
    {
        /// <summary>cookies_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#cookies_config CloudfrontCachePolicy#cookies_config}
        /// </remarks>
        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig CookiesConfig
        {
            get;
            set;
        }

        /// <summary>headers_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#headers_config CloudfrontCachePolicy#headers_config}
        /// </remarks>
        [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig HeadersConfig
        {
            get;
            set;
        }

        /// <summary>query_strings_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_strings_config CloudfrontCachePolicy#query_strings_config}
        /// </remarks>
        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig QueryStringsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#enable_accept_encoding_brotli CloudfrontCachePolicy#enable_accept_encoding_brotli}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableAcceptEncodingBrotli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableAcceptEncodingBrotli
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#enable_accept_encoding_gzip CloudfrontCachePolicy#enable_accept_encoding_gzip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableAcceptEncodingGzip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableAcceptEncodingGzip
        {
            get;
            set;
        }
    }
}
