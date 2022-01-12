using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfiguration")]
    public class AutoscalingPolicyPredictiveScalingConfiguration : aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfiguration
    {
        /// <summary>metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_specification AutoscalingPolicy#metric_specification}
        /// </remarks>
        [JsiiProperty(name: "metricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}", isOverride: true)]
        public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification MetricSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_breach_behavior AutoscalingPolicy#max_capacity_breach_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxCapacityBreachBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_buffer AutoscalingPolicy#max_capacity_buffer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxCapacityBuffer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#mode AutoscalingPolicy#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scheduling_buffer_time AutoscalingPolicy#scheduling_buffer_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SchedulingBufferTime
        {
            get;
            set;
        }
    }
}
