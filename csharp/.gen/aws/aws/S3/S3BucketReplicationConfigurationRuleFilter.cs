using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleFilter")]
    public class S3BucketReplicationConfigurationRuleFilter : aws.S3.IS3BucketReplicationConfigurationRuleFilter
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#and S3BucketReplicationConfigurationA#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterAnd\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleFilterAnd? And
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#prefix S3BucketReplicationConfigurationA#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#tag S3BucketReplicationConfigurationA#tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilterTag\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleFilterTag? Tag
        {
            get;
            set;
        }
    }
}
