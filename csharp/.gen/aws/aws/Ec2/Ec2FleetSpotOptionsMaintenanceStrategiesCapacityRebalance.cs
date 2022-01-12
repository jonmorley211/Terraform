using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance")]
    public class Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance : aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#replacement_strategy Ec2Fleet#replacement_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacementStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReplacementStrategy
        {
            get;
            set;
        }
    }
}
