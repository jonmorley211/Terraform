using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiInterface(nativeType: typeof(IEcrReplicationConfigurationReplicationConfiguration), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfiguration")]
    public interface IEcrReplicationConfigurationReplicationConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}")]
        aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[] Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrReplicationConfigurationReplicationConfiguration), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration#rule EcrReplicationConfiguration#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}")]
            public aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[] Rule
            {
                get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[]>()!;
            }
        }
    }
}
