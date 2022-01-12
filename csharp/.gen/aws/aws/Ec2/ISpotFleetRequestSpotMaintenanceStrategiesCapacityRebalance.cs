using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
    public interface ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacementStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance), fullyQualifiedName: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacementStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
