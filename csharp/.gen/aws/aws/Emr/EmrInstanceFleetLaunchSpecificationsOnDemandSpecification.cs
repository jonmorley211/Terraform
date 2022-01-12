using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrInstanceFleetLaunchSpecificationsOnDemandSpecification")]
    public class EmrInstanceFleetLaunchSpecificationsOnDemandSpecification : aws.Emr.IEmrInstanceFleetLaunchSpecificationsOnDemandSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#allocation_strategy EmrInstanceFleet#allocation_strategy}.</summary>
        [JsiiProperty(name: "allocationStrategy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AllocationStrategy
        {
            get;
            set;
        }
    }
}
