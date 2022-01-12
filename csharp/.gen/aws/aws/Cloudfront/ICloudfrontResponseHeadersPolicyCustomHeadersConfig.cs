using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicyCustomHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfig")]
    public interface ICloudfrontResponseHeadersPolicyCustomHeadersConfig
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#items CloudfrontResponseHeadersPolicy#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigItems\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfigItems[]? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicyCustomHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#items CloudfrontResponseHeadersPolicy#items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigItems\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfigItems[]? Items
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfigItems[]?>();
            }
        }
    }
}
