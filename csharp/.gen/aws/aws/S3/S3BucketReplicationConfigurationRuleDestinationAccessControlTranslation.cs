using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation")]
    public class S3BucketReplicationConfigurationRuleDestinationAccessControlTranslation : aws.S3.IS3BucketReplicationConfigurationRuleDestinationAccessControlTranslation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#owner S3BucketReplicationConfigurationA#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Owner
        {
            get;
            set;
        }
    }
}
