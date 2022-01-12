using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRule")]
    public interface IS3BucketReplicationConfigurationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#destination S3BucketReplicationConfigurationA#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestination\"}")]
        aws.S3.IS3BucketReplicationConfigurationRuleDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>delete_marker_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#delete_marker_replication S3BucketReplicationConfigurationA#delete_marker_replication}
        /// </remarks>
        [JsiiProperty(name: "deleteMarkerReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDeleteMarkerReplication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleDeleteMarkerReplication? DeleteMarkerReplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>existing_object_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#existing_object_replication S3BucketReplicationConfigurationA#existing_object_replication}
        /// </remarks>
        [JsiiProperty(name: "existingObjectReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleExistingObjectReplication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleExistingObjectReplication? ExistingObjectReplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#filter S3BucketReplicationConfigurationA#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#id S3BucketReplicationConfigurationA#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#prefix S3BucketReplicationConfigurationA#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#priority S3BucketReplicationConfigurationA#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_selection_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#source_selection_criteria S3BucketReplicationConfigurationA#source_selection_criteria}
        /// </remarks>
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria? SourceSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#destination S3BucketReplicationConfigurationA#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDestination\"}")]
            public aws.S3.IS3BucketReplicationConfigurationRuleDestination Destination
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#status S3BucketReplicationConfigurationA#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>delete_marker_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#delete_marker_replication S3BucketReplicationConfigurationA#delete_marker_replication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteMarkerReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleDeleteMarkerReplication\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleDeleteMarkerReplication? DeleteMarkerReplication
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleDeleteMarkerReplication?>();
            }

            /// <summary>existing_object_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#existing_object_replication S3BucketReplicationConfigurationA#existing_object_replication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "existingObjectReplication", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleExistingObjectReplication\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleExistingObjectReplication? ExistingObjectReplication
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleExistingObjectReplication?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#filter S3BucketReplicationConfigurationA#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleFilter\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleFilter? Filter
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#id S3BucketReplicationConfigurationA#id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#prefix S3BucketReplicationConfigurationA#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#priority S3BucketReplicationConfigurationA#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_selection_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_replication_configuration#source_selection_criteria S3BucketReplicationConfigurationA#source_selection_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRuleSourceSelectionCriteria\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria? SourceSelectionCriteria
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRuleSourceSelectionCriteria?>();
            }
        }
    }
}
