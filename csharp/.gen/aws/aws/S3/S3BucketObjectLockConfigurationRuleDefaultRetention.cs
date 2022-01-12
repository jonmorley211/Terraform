using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketObjectLockConfigurationRuleDefaultRetention")]
    public class S3BucketObjectLockConfigurationRuleDefaultRetention : aws.S3.IS3BucketObjectLockConfigurationRuleDefaultRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#mode S3Bucket#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Mode
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#years S3Bucket#years}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Years
        {
            get;
            set;
        }
    }
}
