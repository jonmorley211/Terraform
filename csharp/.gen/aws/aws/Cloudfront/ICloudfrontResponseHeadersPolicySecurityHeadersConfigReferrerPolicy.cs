using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy")]
    public interface ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Override
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}.</summary>
        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string ReferrerPolicy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
            [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Override
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}.</summary>
            [JsiiProperty(name: "referrerPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string ReferrerPolicy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
