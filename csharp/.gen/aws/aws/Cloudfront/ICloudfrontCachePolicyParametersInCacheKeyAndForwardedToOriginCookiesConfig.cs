using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig")]
    public interface ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#cookie_behavior CloudfrontCachePolicy#cookie_behavior}.</summary>
        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string CookieBehavior
        {
            get;
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#cookies CloudfrontCachePolicy#cookies}
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#cookie_behavior CloudfrontCachePolicy#cookie_behavior}.</summary>
            [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string CookieBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_cache_policy#cookies CloudfrontCachePolicy#cookies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies?>();
            }
        }
    }
}
