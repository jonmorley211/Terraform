using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>AWS CloudFront.</summary>
    [JsiiInterface(nativeType: typeof(ICloudfrontOriginRequestPolicyConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyConfig")]
    public interface ICloudfrontOriginRequestPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>cookies_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookies_config CloudfrontOriginRequestPolicy#cookies_config}
        /// </remarks>
        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig\"}")]
        aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig CookiesConfig
        {
            get;
        }

        /// <summary>headers_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#headers_config CloudfrontOriginRequestPolicy#headers_config}
        /// </remarks>
        [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig\"}")]
        aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig HeadersConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#name CloudfrontOriginRequestPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>query_strings_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#query_strings_config CloudfrontOriginRequestPolicy#query_strings_config}
        /// </remarks>
        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig\"}")]
        aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig QueryStringsConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#comment CloudfrontOriginRequestPolicy#comment}.</summary>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CloudFront.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudfrontOriginRequestPolicyConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontOriginRequestPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cookies_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookies_config CloudfrontOriginRequestPolicy#cookies_config}
            /// </remarks>
            [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig\"}")]
            public aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig CookiesConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig>()!;
            }

            /// <summary>headers_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#headers_config CloudfrontOriginRequestPolicy#headers_config}
            /// </remarks>
            [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig\"}")]
            public aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig HeadersConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#name CloudfrontOriginRequestPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>query_strings_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#query_strings_config CloudfrontOriginRequestPolicy#query_strings_config}
            /// </remarks>
            [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig\"}")]
            public aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig QueryStringsConfig
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#comment CloudfrontOriginRequestPolicy#comment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
