using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification")]
    public class EmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification : aws.Emr.IEmrClusterMasterInstanceFleetLaunchSpecificationsSpotSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AllocationStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#timeout_action EmrCluster#timeout_action}.</summary>
        [JsiiProperty(name: "timeoutAction", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimeoutAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#timeout_duration_minutes EmrCluster#timeout_duration_minutes}.</summary>
        [JsiiProperty(name: "timeoutDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double TimeoutDurationMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#block_duration_minutes EmrCluster#block_duration_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BlockDurationMinutes
        {
            get;
            set;
        }
    }
}
