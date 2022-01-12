using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction")]
    public class AutoscalingplansScalingPlanScalingInstruction : aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#max_capacity AutoscalingplansScalingPlan#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#min_capacity AutoscalingplansScalingPlan#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MinCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_id AutoscalingplansScalingPlan#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scalable_dimension AutoscalingplansScalingPlan#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScalableDimension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#service_namespace AutoscalingplansScalingPlan#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceNamespace
        {
            get;
            set;
        }

        /// <summary>target_tracking_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#target_tracking_configuration AutoscalingplansScalingPlan#target_tracking_configuration}
        /// </remarks>
        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration[] TargetTrackingConfiguration
        {
            get;
            set;
        }

        /// <summary>customized_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#customized_load_metric_specification AutoscalingplansScalingPlan#customized_load_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#disable_dynamic_scaling AutoscalingplansScalingPlan#disable_dynamic_scaling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableDynamicScaling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? DisableDynamicScaling
        {
            get;
            set;
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_specification AutoscalingplansScalingPlan#predefined_load_metric_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_behavior AutoscalingplansScalingPlan#predictive_scaling_max_capacity_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predictiveScalingMaxCapacityBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PredictiveScalingMaxCapacityBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_buffer AutoscalingplansScalingPlan#predictive_scaling_max_capacity_buffer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predictiveScalingMaxCapacityBuffer", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PredictiveScalingMaxCapacityBuffer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_mode AutoscalingplansScalingPlan#predictive_scaling_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "predictiveScalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PredictiveScalingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scaling_policy_update_behavior AutoscalingplansScalingPlan#scaling_policy_update_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicyUpdateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ScalingPolicyUpdateBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scheduled_action_buffer_time AutoscalingplansScalingPlan#scheduled_action_buffer_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledActionBufferTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ScheduledActionBufferTime
        {
            get;
            set;
        }
    }
}
