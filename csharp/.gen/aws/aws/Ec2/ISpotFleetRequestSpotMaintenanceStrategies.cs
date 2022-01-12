using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiInterface(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategies), fullyQualifiedName: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategies")]
    public interface ISpotFleetRequestSpotMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
        /// </remarks>
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotFleetRequestSpotMaintenanceStrategies), fullyQualifiedName: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategies")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capacity_rebalance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true)]
            public aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
            {
                get => GetInstanceProperty<aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance?>();
            }
        }
    }
}
