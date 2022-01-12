using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRule")]
    public class S3BucketReplicationConfigurationRule : aws.S3.IS3BucketReplicationConfigurationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#destination S3BucketReplicationConfigurationA#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestination\"}", isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleDestination Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Status
        {
            get;
            set;
        }

        /// <summary>delete_marker_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#delete_marker_replication S3BucketReplicationConfigurationA#delete_marker_replication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteMarkerReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDeleteMarkerReplication\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleDeleteMarkerReplication? DeleteMarkerReplication
        {
            get;
            set;
        }

        /// <summary>existing_object_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#existing_object_replication S3BucketReplicationConfigurationA#existing_object_replication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "existingObjectReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleExistingObjectReplication\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleExistingObjectReplication? ExistingObjectReplication
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#filter S3BucketReplicationConfigurationA#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilter\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#id S3BucketReplicationConfigurationA#id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Id
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#priority S3BucketReplicationConfigurationA#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>source_selection_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#source_selection_criteria S3BucketReplicationConfigurationA#source_selection_criteria}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria? SourceSelectionCriteria
        {
            get;
            set;
        }
    }
}
