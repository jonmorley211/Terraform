using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrClusterCoreInstanceFleetLaunchSpecifications")]
    public class EmrClusterCoreInstanceFleetLaunchSpecifications : aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecifications
    {
        /// <summary>on_demand_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#on_demand_specification EmrCluster#on_demand_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[]? OnDemandSpecification
        {
            get;
            set;
        }

        /// <summary>spot_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#spot_specification EmrCluster#spot_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spotSpecification", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[]? SpotSpecification
        {
            get;
            set;
        }
    }
}
