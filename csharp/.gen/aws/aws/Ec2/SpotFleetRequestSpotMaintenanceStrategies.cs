using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategies")]
    public class SpotFleetRequestSpotMaintenanceStrategies : aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#capacity_rebalance SpotFleetRequest#capacity_rebalance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get;
            set;
        }
    }
}
