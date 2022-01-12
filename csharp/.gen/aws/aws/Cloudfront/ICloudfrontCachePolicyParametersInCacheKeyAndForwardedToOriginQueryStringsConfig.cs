using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig")]
    public interface ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_string_behavior CloudfrontCachePolicy#query_string_behavior}.</summary>
        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string QueryStringBehavior
        {
            get;
        }

        /// <summary>query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_strings CloudfrontCachePolicy#query_strings}
        /// </remarks>
        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_string_behavior CloudfrontCachePolicy#query_string_behavior}.</summary>
            [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryStringBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>query_strings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#query_strings CloudfrontCachePolicy#query_strings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings?>();
            }
        }
    }
}
