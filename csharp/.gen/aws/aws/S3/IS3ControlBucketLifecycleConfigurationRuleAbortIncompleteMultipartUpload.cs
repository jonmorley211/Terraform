using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload), fullyQualifiedName: "aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
    public interface IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#days_after_initiation S3ControlBucketLifecycleConfiguration#days_after_initiation}.</summary>
        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}")]
        double DaysAfterInitiation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload), fullyQualifiedName: "aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#days_after_initiation S3ControlBucketLifecycleConfiguration#days_after_initiation}.</summary>
            [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}")]
            public double DaysAfterInitiation
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
