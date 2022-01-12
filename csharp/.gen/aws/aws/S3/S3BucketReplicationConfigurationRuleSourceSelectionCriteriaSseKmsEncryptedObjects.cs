using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects")]
    public class S3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects : aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteriaSseKmsEncryptedObjects
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Status
        {
            get;
            set;
        }
    }
}
