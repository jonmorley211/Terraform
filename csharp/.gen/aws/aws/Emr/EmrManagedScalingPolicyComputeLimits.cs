using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrManagedScalingPolicyComputeLimits")]
    public class EmrManagedScalingPolicyComputeLimits : aws.Emr.IEmrManagedScalingPolicyComputeLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_managed_scaling_policy#maximum_capacity_units EmrManagedScalingPolicy#maximum_capacity_units}.</summary>
        [JsiiProperty(name: "maximumCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaximumCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_managed_scaling_policy#minimum_capacity_units EmrManagedScalingPolicy#minimum_capacity_units}.</summary>
        [JsiiProperty(name: "minimumCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MinimumCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_managed_scaling_policy#unit_type EmrManagedScalingPolicy#unit_type}.</summary>
        [JsiiProperty(name: "unitType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UnitType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_managed_scaling_policy#maximum_core_capacity_units EmrManagedScalingPolicy#maximum_core_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumCoreCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumCoreCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_managed_scaling_policy#maximum_ondemand_capacity_units EmrManagedScalingPolicy#maximum_ondemand_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumOndemandCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumOndemandCapacityUnits
        {
            get;
            set;
        }
    }
}
