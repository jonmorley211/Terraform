using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTime")]
    public class S3BucketReplicationConfigurationRuleDestinationReplicationTime : aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#time S3BucketReplicationConfigurationA#time}
        /// </remarks>
        [JsiiProperty(name: "time", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestinationReplicationTimeTime\"}", isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleDestinationReplicationTimeTime Time
        {
            get;
            set;
        }
    }
}
