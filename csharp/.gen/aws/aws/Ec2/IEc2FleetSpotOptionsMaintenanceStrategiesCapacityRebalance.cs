using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
    public interface IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
