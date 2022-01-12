using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstruction), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction")]
    public interface IAutoscalingplansScalingPlanScalingInstruction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#max_capacity AutoscalingplansScalingPlan#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MaxCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#min_capacity AutoscalingplansScalingPlan#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MinCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_id AutoscalingplansScalingPlan#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scalable_dimension AutoscalingplansScalingPlan#scalable_dimension}.</summary>
        [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
        string ScalableDimension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#service_namespace AutoscalingplansScalingPlan#service_namespace}.</summary>
        [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceNamespace
        {
            get;
        }

        /// <summary>target_tracking_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#target_tracking_configuration AutoscalingplansScalingPlan#target_tracking_configuration}
        /// </remarks>
        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration\"},\"kind\":\"array\"}}")]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration[] TargetTrackingConfiguration
        {
            get;
        }

        /// <summary>customized_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#customized_load_metric_specification AutoscalingplansScalingPlan#customized_load_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#disable_dynamic_scaling AutoscalingplansScalingPlan#disable_dynamic_scaling}.</summary>
        [JsiiProperty(name: "disableDynamicScaling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableDynamicScaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_specification AutoscalingplansScalingPlan#predefined_load_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_behavior AutoscalingplansScalingPlan#predictive_scaling_max_capacity_behavior}.</summary>
        [JsiiProperty(name: "predictiveScalingMaxCapacityBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PredictiveScalingMaxCapacityBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_buffer AutoscalingplansScalingPlan#predictive_scaling_max_capacity_buffer}.</summary>
        [JsiiProperty(name: "predictiveScalingMaxCapacityBuffer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PredictiveScalingMaxCapacityBuffer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_mode AutoscalingplansScalingPlan#predictive_scaling_mode}.</summary>
        [JsiiProperty(name: "predictiveScalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PredictiveScalingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scaling_policy_update_behavior AutoscalingplansScalingPlan#scaling_policy_update_behavior}.</summary>
        [JsiiProperty(name: "scalingPolicyUpdateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalingPolicyUpdateBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scheduled_action_buffer_time AutoscalingplansScalingPlan#scheduled_action_buffer_time}.</summary>
        [JsiiProperty(name: "scheduledActionBufferTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScheduledActionBufferTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstruction), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#max_capacity AutoscalingplansScalingPlan#max_capacity}.</summary>
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#min_capacity AutoscalingplansScalingPlan#min_capacity}.</summary>
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MinCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#resource_id AutoscalingplansScalingPlan#resource_id}.</summary>
            [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scalable_dimension AutoscalingplansScalingPlan#scalable_dimension}.</summary>
            [JsiiProperty(name: "scalableDimension", typeJson: "{\"primitive\":\"string\"}")]
            public string ScalableDimension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#service_namespace AutoscalingplansScalingPlan#service_namespace}.</summary>
            [JsiiProperty(name: "serviceNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target_tracking_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#target_tracking_configuration AutoscalingplansScalingPlan#target_tracking_configuration}
            /// </remarks>
            [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration\"},\"kind\":\"array\"}}")]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration[] TargetTrackingConfiguration
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration[]>()!;
            }

            /// <summary>customized_load_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#customized_load_metric_specification AutoscalingplansScalingPlan#customized_load_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification\"}", isOptional: true)]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionCustomizedLoadMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#disable_dynamic_scaling AutoscalingplansScalingPlan#disable_dynamic_scaling}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableDynamicScaling", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableDynamicScaling
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>predefined_load_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_load_metric_specification AutoscalingplansScalingPlan#predefined_load_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification\"}", isOptional: true)]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_behavior AutoscalingplansScalingPlan#predictive_scaling_max_capacity_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predictiveScalingMaxCapacityBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PredictiveScalingMaxCapacityBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_max_capacity_buffer AutoscalingplansScalingPlan#predictive_scaling_max_capacity_buffer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predictiveScalingMaxCapacityBuffer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PredictiveScalingMaxCapacityBuffer
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predictive_scaling_mode AutoscalingplansScalingPlan#predictive_scaling_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "predictiveScalingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PredictiveScalingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scaling_policy_update_behavior AutoscalingplansScalingPlan#scaling_policy_update_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingPolicyUpdateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalingPolicyUpdateBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scheduled_action_buffer_time AutoscalingplansScalingPlan#scheduled_action_buffer_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledActionBufferTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScheduledActionBufferTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
