using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrInstanceFleetLaunchSpecifications")]
    public class EmrInstanceFleetLaunchSpecifications : aws.Emr.IEmrInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#on_demand_specification EmrInstanceFleet#on_demand_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
        {
            get;
            set;
        }

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#spot_specification EmrInstanceFleet#spot_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
        {
            get;
            set;
        }
    }
}
