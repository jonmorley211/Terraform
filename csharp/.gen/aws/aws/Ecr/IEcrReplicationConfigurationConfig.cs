using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>AWS EC2 Container Registry.</summary>
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationConfig), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationConfig")]
    public interface IEcrReplicationConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>replication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#replication_configuration EcrReplicationConfiguration#replication_configuration}
        /// </remarks>
        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration? ReplicationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Registry.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationConfig), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrReplicationConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>replication_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#replication_configuration EcrReplicationConfiguration#replication_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfiguration\"}", isOptional: true)]
            public aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration? ReplicationConfiguration
            {
                get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration?>();
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
