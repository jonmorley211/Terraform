using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior")]
    public interface ICloudfrontDistributionDefaultCacheBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#allowed_methods CloudfrontDistribution#allowed_methods}.</summary>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMethods
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cached_methods CloudfrontDistribution#cached_methods}.</summary>
        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CachedMethods
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#target_origin_id CloudfrontDistribution#target_origin_id}.</summary>
        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetOriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_protocol_policy CloudfrontDistribution#viewer_protocol_policy}.</summary>
        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string ViewerProtocolPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cache_policy_id CloudfrontDistribution#cache_policy_id}.</summary>
        [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachePolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#compress CloudfrontDistribution#compress}.</summary>
        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_ttl CloudfrontDistribution#default_ttl}.</summary>
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#field_level_encryption_id CloudfrontDistribution#field_level_encryption_id}.</summary>
        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldLevelEncryptionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarded_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forwarded_values CloudfrontDistribution#forwarded_values}
        /// </remarks>
        [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues? ForwardedValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#function_association CloudfrontDistribution#function_association}
        /// </remarks>
        [JsiiProperty(name: "functionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorFunctionAssociation[]? FunctionAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_association block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_function_association CloudfrontDistribution#lambda_function_association}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation[]? LambdaFunctionAssociation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#max_ttl CloudfrontDistribution#max_ttl}.</summary>
        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#min_ttl CloudfrontDistribution#min_ttl}.</summary>
        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_request_policy_id CloudfrontDistribution#origin_request_policy_id}.</summary>
        [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginRequestPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#realtime_log_config_arn CloudfrontDistribution#realtime_log_config_arn}.</summary>
        [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RealtimeLogConfigArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#response_headers_policy_id CloudfrontDistribution#response_headers_policy_id}.</summary>
        [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseHeadersPolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#smooth_streaming CloudfrontDistribution#smooth_streaming}.</summary>
        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SmoothStreaming
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_key_groups CloudfrontDistribution#trusted_key_groups}.</summary>
        [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedKeyGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_signers CloudfrontDistribution#trusted_signers}.</summary>
        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedSigners
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionDefaultCacheBehavior), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#allowed_methods CloudfrontDistribution#allowed_methods}.</summary>
            [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cached_methods CloudfrontDistribution#cached_methods}.</summary>
            [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CachedMethods
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#target_origin_id CloudfrontDistribution#target_origin_id}.</summary>
            [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#viewer_protocol_policy CloudfrontDistribution#viewer_protocol_policy}.</summary>
            [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string ViewerProtocolPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#cache_policy_id CloudfrontDistribution#cache_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cachePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CachePolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#compress CloudfrontDistribution#compress}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Compress
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#default_ttl CloudfrontDistribution#default_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#field_level_encryption_id CloudfrontDistribution#field_level_encryption_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldLevelEncryptionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>forwarded_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#forwarded_values CloudfrontDistribution#forwarded_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValues\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues? ForwardedValues
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues?>();
            }

            /// <summary>function_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#function_association CloudfrontDistribution#function_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "functionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorFunctionAssociation[]? FunctionAssociation
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorFunctionAssociation[]?>();
            }

            /// <summary>lambda_function_association block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#lambda_function_association CloudfrontDistribution#lambda_function_association}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation[]? LambdaFunctionAssociation
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#max_ttl CloudfrontDistribution#max_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#min_ttl CloudfrontDistribution#min_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_request_policy_id CloudfrontDistribution#origin_request_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originRequestPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginRequestPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#realtime_log_config_arn CloudfrontDistribution#realtime_log_config_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "realtimeLogConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RealtimeLogConfigArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#response_headers_policy_id CloudfrontDistribution#response_headers_policy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeadersPolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseHeadersPolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#smooth_streaming CloudfrontDistribution#smooth_streaming}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SmoothStreaming
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_key_groups CloudfrontDistribution#trusted_key_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedKeyGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedKeyGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#trusted_signers CloudfrontDistribution#trusted_signers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedSigners
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
