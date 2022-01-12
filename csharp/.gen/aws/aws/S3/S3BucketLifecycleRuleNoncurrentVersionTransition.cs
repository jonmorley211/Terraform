using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketLifecycleRuleNoncurrentVersionTransition")]
    public class S3BucketLifecycleRuleNoncurrentVersionTransition : aws.S3.IS3BucketLifecycleRuleNoncurrentVersionTransition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#storage_class S3Bucket#storage_class}.</summary>
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StorageClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#days S3Bucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}
