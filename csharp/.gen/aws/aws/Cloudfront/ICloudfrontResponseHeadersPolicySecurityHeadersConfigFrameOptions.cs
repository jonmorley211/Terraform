using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions")]
    public interface ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#frame_option CloudfrontResponseHeadersPolicy#frame_option}.</summary>
        [JsiiProperty(name: "frameOption", typeJson: "{\"primitive\":\"string\"}")]
        string FrameOption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
        [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Override
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#frame_option CloudfrontResponseHeadersPolicy#frame_option}.</summary>
            [JsiiProperty(name: "frameOption", typeJson: "{\"primitive\":\"string\"}")]
            public string FrameOption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#override CloudfrontResponseHeadersPolicy#override}.</summary>
            [JsiiProperty(name: "override", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Override
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
