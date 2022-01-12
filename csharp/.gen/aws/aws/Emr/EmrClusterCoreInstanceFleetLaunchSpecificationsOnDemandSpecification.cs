using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public class EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification : aws.Emr.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#allocation_strategy EmrCluster#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AllocationStrategy
        {
            get;
            set;
        }
    }
}
