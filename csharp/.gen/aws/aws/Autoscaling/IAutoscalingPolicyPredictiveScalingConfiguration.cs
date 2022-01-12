using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyPredictiveScalingConfiguration), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfiguration")]
    public interface IAutoscalingPolicyPredictiveScalingConfiguration
    {
        /// <summary>metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_specification AutoscalingPolicy#metric_specification}
        /// </remarks>
        [JsiiProperty(name: "metricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}")]
        aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification MetricSpecification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_breach_behavior AutoscalingPolicy#max_capacity_breach_behavior}.</summary>
        [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxCapacityBreachBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_buffer AutoscalingPolicy#max_capacity_buffer}.</summary>
        [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxCapacityBuffer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#mode AutoscalingPolicy#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scheduling_buffer_time AutoscalingPolicy#scheduling_buffer_time}.</summary>
        [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchedulingBufferTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyPredictiveScalingConfiguration), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#metric_specification AutoscalingPolicy#metric_specification}
            /// </remarks>
            [JsiiProperty(name: "metricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}")]
            public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification MetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_breach_behavior AutoscalingPolicy#max_capacity_breach_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxCapacityBreachBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#max_capacity_buffer AutoscalingPolicy#max_capacity_buffer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxCapacityBuffer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#mode AutoscalingPolicy#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#scheduling_buffer_time AutoscalingPolicy#scheduling_buffer_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchedulingBufferTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
