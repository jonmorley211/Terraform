using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance")]
    public class SpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance : aws.Ec2.ISpotFleetRequestSpotMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_fleet_request#replacement_strategy SpotFleetRequest#replacement_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplacementStrategy
        {
            get;
            set;
        }
    }
}
