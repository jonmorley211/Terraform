using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
    public interface IEcrReplicationConfigurationReplicationConfigurationRuleDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        string RegistryId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfigurationRuleDestination), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationRuleDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRuleDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#region EcrReplicationConfiguration#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#registry_id EcrReplicationConfiguration#registry_id}.</summary>
            [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
            public string RegistryId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
