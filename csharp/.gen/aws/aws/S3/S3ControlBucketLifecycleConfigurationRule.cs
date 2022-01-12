using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlBucketLifecycleConfigurationRule")]
    public class S3ControlBucketLifecycleConfigurationRule : aws.S3.IS3ControlBucketLifecycleConfigurationRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#id S3ControlBucketLifecycleConfiguration#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Id
        {
            get;
            set;
        }

        /// <summary>abort_incomplete_multipart_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#abort_incomplete_multipart_upload S3ControlBucketLifecycleConfiguration#abort_incomplete_multipart_upload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUpload", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload? AbortIncompleteMultipartUpload
        {
            get;
            set;
        }

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#expiration S3ControlBucketLifecycleConfiguration#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleExpiration\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3ControlBucketLifecycleConfigurationRuleExpiration? Expiration
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#filter S3ControlBucketLifecycleConfiguration#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3ControlBucketLifecycleConfigurationRuleFilter\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3ControlBucketLifecycleConfigurationRuleFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#status S3ControlBucketLifecycleConfiguration#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
