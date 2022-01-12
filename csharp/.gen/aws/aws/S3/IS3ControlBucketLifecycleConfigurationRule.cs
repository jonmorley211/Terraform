using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlBucketLifecycleConfigurationRule), fullyQualifiedName: "aws.s3.S3ControlBucketLifecycleConfigurationRule")]
    public interface IS3ControlBucketLifecycleConfigurationRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#id S3ControlBucketLifecycleConfiguration#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>abort_incomplete_multipart_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#abort_incomplete_multipart_upload S3ControlBucketLifecycleConfiguration#abort_incomplete_multipart_upload}
        /// </remarks>
        [JsiiProperty(name: "abortIncompleteMultipartUpload", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? AbortIncompleteMultipartUpload
        {
            get
            {
                return null;
            }
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#expiration S3ControlBucketLifecycleConfiguration#expiration}
        /// </remarks>
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleExpiration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3ControlBucketLifecycleConfigurationRuleExpiration? Expiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#filter S3ControlBucketLifecycleConfiguration#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3ControlBucketLifecycleConfigurationRuleFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#status S3ControlBucketLifecycleConfiguration#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlBucketLifecycleConfigurationRule), fullyQualifiedName: "aws.s3.S3ControlBucketLifecycleConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlBucketLifecycleConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#id S3ControlBucketLifecycleConfiguration#id}.</summary>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>abort_incomplete_multipart_upload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#abort_incomplete_multipart_upload S3ControlBucketLifecycleConfiguration#abort_incomplete_multipart_upload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "abortIncompleteMultipartUpload", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true)]
            public aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? AbortIncompleteMultipartUpload
            {
                get => GetInstanceProperty<aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload?>();
            }

            /// <summary>expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#expiration S3ControlBucketLifecycleConfiguration#expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleExpiration\"}", isOptional: true)]
            public aws.S3.IS3ControlBucketLifecycleConfigurationRuleExpiration? Expiration
            {
                get => GetInstanceProperty<aws.S3.IS3ControlBucketLifecycleConfigurationRuleExpiration?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#filter S3ControlBucketLifecycleConfiguration#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleFilter\"}", isOptional: true)]
            public aws.S3.IS3ControlBucketLifecycleConfigurationRuleFilter? Filter
            {
                get => GetInstanceProperty<aws.S3.IS3ControlBucketLifecycleConfigurationRuleFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#status S3ControlBucketLifecycleConfiguration#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
