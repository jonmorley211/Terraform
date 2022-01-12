using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig")]
    public interface ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#header_behavior CloudfrontCachePolicy#header_behavior}.</summary>
        [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#headers CloudfrontCachePolicy#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#header_behavior CloudfrontCachePolicy#header_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#headers CloudfrontCachePolicy#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders?>();
            }
        }
    }
}
