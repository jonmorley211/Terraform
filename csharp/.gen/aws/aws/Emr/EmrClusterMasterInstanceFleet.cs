using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrClusterMasterInstanceFleet")]
    public class EmrClusterMasterInstanceFleet : aws.Emr.IEmrClusterMasterInstanceFleet
    {
        /// <summary>instance_type_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type_configs EmrCluster#instance_type_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigs
        {
            get;
            set;
        }

        /// <summary>launch_specifications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#launch_specifications EmrCluster#launch_specifications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetLaunchSpecifications\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecifications? LaunchSpecifications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_on_demand_capacity EmrCluster#target_on_demand_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TargetOnDemandCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#target_spot_capacity EmrCluster#target_spot_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TargetSpotCapacity
        {
            get;
            set;
        }
    }
}
