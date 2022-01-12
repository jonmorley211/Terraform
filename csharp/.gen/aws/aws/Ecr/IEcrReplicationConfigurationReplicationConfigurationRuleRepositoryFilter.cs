using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter")]
    public interface IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#filter EcrReplicationConfiguration#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
        string Filter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#filter_type EcrReplicationConfiguration#filter_type}.</summary>
        [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
        string FilterType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleRepositoryFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#filter EcrReplicationConfiguration#filter}.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}")]
            public string Filter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#filter_type EcrReplicationConfiguration#filter_type}.</summary>
            [JsiiProperty(name: "filterType", typeJson: "{\"primitive\":\"string\"}")]
            public string FilterType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
