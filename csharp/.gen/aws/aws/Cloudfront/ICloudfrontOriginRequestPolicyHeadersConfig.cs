using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontOriginRequestPolicyHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig")]
    public interface ICloudfrontOriginRequestPolicyHeadersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#header_behavior CloudfrontOriginRequestPolicy#header_behavior}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#headers CloudfrontOriginRequestPolicy#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders? Headers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontOriginRequestPolicyHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#header_behavior CloudfrontOriginRequestPolicy#header_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#headers CloudfrontOriginRequestPolicy#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders? Headers
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders?>();
            }
        }
    }
}
