using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontOriginRequestPolicyCookiesConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig")]
    public interface ICloudfrontOriginRequestPolicyCookiesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookie_behavior CloudfrontOriginRequestPolicy#cookie_behavior}.</summary>
        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string CookieBehavior
        {
            get;
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookies CloudfrontOriginRequestPolicy#cookies}
        /// </remarks>
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies? Cookies
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontOriginRequestPolicyCookiesConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookie_behavior CloudfrontOriginRequestPolicy#cookie_behavior}.</summary>
            [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string CookieBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cookies block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookies CloudfrontOriginRequestPolicy#cookies}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies? Cookies
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies?>();
            }
        }
    }
}
