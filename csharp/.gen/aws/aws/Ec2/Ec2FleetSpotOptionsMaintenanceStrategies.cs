using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiByValue(fqn: "aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategies")]
    public class Ec2FleetSpotOptionsMaintenanceStrategies : aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategies
    {
        /// <summary>capacity_rebalance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ec2_fleet#capacity_rebalance Ec2Fleet#capacity_rebalance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityRebalance", typeJson: "{\"fqn\":\"aws.ec2.Ec2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.IEc2FleetSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance
        {
            get;
            set;
        }
    }
}
