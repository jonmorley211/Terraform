using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload")]
    public class S3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload : aws.S3.IS3ControlBucketLifecycleConfigurationRuleAbortIncompleteMultipartUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_bucket_lifecycle_configuration#days_after_initiation S3ControlBucketLifecycleConfiguration#days_after_initiation}.</summary>
        [JsiiProperty(name: "daysAfterInitiation", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double DaysAfterInitiation
        {
            get;
            set;
        }
    }
}
