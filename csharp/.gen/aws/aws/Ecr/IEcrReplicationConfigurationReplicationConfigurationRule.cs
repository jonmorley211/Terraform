using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRule), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule")]
    public interface IEcrReplicationConfigurationReplicationConfigurationRule
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}")]
        aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination[] Destination
        {
            get;
        }

        /// <summary>repository_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
        /// </remarks>
        [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter[]? RepositoryFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRule), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#destination EcrReplicationConfiguration#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination\"},\"kind\":\"array\"}}")]
            public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination[] Destination
            {
                get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination[]>()!;
            }

            /// <summary>repository_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#repository_filter EcrReplicationConfiguration#repository_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter[]? RepositoryFilter
            {
                get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter[]?>();
            }
        }
    }
}
