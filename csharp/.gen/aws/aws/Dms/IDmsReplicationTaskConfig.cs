using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    /// <summary>AWS Database Migration Service.</summary>
    [JsiiInterface(nativeType: typeof(IDmsReplicationTaskConfig), fullyQualifiedName: "aws.dms.DmsReplicationTaskConfig")]
    public interface IDmsReplicationTaskConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#migration_type DmsReplicationTask#migration_type}.</summary>
        [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
        string MigrationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_instance_arn DmsReplicationTask#replication_instance_arn}.</summary>
        [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationInstanceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_task_id DmsReplicationTask#replication_task_id}.</summary>
        [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
        string ReplicationTaskId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#source_endpoint_arn DmsReplicationTask#source_endpoint_arn}.</summary>
        [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        string SourceEndpointArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#table_mappings DmsReplicationTask#table_mappings}.</summary>
        [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
        string TableMappings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#target_endpoint_arn DmsReplicationTask#target_endpoint_arn}.</summary>
        [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetEndpointArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#cdc_start_position DmsReplicationTask#cdc_start_position}.</summary>
        [JsiiProperty(name: "cdcStartPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CdcStartPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#cdc_start_time DmsReplicationTask#cdc_start_time}.</summary>
        [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CdcStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_task_settings DmsReplicationTask#replication_task_settings}.</summary>
        [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationTaskSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#tags DmsReplicationTask#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#tags_all DmsReplicationTask#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Database Migration Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDmsReplicationTaskConfig), fullyQualifiedName: "aws.dms.DmsReplicationTaskConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Dms.IDmsReplicationTaskConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#migration_type DmsReplicationTask#migration_type}.</summary>
            [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
            public string MigrationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_instance_arn DmsReplicationTask#replication_instance_arn}.</summary>
            [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_task_id DmsReplicationTask#replication_task_id}.</summary>
            [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
            public string ReplicationTaskId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#source_endpoint_arn DmsReplicationTask#source_endpoint_arn}.</summary>
            [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceEndpointArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#table_mappings DmsReplicationTask#table_mappings}.</summary>
            [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
            public string TableMappings
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#target_endpoint_arn DmsReplicationTask#target_endpoint_arn}.</summary>
            [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetEndpointArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#cdc_start_position DmsReplicationTask#cdc_start_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cdcStartPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CdcStartPosition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#cdc_start_time DmsReplicationTask#cdc_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CdcStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#replication_task_settings DmsReplicationTask#replication_task_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationTaskSettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#tags DmsReplicationTask#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_replication_task#tags_all DmsReplicationTask#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TagsAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
