using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesDestinationReplicationTime")]
    public class S3BucketReplicationConfigurationRulesDestinationReplicationTime : aws.S3.IS3BucketReplicationConfigurationRulesDestinationReplicationTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#minutes S3Bucket#minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Minutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#status S3Bucket#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
