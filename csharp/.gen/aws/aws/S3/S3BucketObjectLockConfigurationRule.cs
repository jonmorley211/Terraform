using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketObjectLockConfigurationRule")]
    public class S3BucketObjectLockConfigurationRule : aws.S3.IS3BucketObjectLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#default_retention S3Bucket#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRuleDefaultRetention\"}", isOverride: true)]
        public aws.S3.IS3BucketObjectLockConfigurationRuleDefaultRetention DefaultRetention
        {
            get;
            set;
        }
    }
}
