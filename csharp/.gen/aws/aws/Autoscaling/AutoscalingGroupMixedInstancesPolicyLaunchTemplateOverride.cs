using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride")]
    public class AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride : aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#instance_type AutoscalingGroup#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#launch_template_specification AutoscalingGroup#launch_template_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_group#weighted_capacity AutoscalingGroup#weighted_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WeightedCapacity
        {
            get;
            set;
        }
    }
}
