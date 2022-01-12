using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification")]
    public class AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification : aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_type AutoscalingplansScalingPlan#predefined_load_metric_type}.</summary>
        [JsiiProperty(name: "predefinedLoadMetricType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PredefinedLoadMetricType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_label AutoscalingplansScalingPlan#resource_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResourceLabel
        {
            get;
            set;
        }
    }
}
