using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold")]
    public class S3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold : aws.S3.IS3BucketReplicationConfigurationRuleDestinationMetricsEventThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#minutes S3BucketReplicationConfigurationA#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Minutes
        {
            get;
            set;
        }
    }
}
