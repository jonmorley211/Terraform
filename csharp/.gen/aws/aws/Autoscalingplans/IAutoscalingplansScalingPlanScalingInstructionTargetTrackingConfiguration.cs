using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration")]
    public interface IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#target_value AutoscalingplansScalingPlan#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>customized_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#customized_scaling_metric_specification AutoscalingplansScalingPlan#customized_scaling_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#disable_scale_in AutoscalingplansScalingPlan#disable_scale_in}.</summary>
        [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableScaleIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#estimated_instance_warmup AutoscalingplansScalingPlan#estimated_instance_warmup}.</summary>
        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EstimatedInstanceWarmup
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_scaling_metric_specification AutoscalingplansScalingPlan#predefined_scaling_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scale_in_cooldown AutoscalingplansScalingPlan#scale_in_cooldown}.</summary>
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleInCooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scale_out_cooldown AutoscalingplansScalingPlan#scale_out_cooldown}.</summary>
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleOutCooldown
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#target_value AutoscalingplansScalingPlan#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>customized_scaling_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#customized_scaling_metric_specification AutoscalingplansScalingPlan#customized_scaling_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customizedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification\"}", isOptional: true)]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#disable_scale_in AutoscalingplansScalingPlan#disable_scale_in}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableScaleIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DisableScaleIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#estimated_instance_warmup AutoscalingplansScalingPlan#estimated_instance_warmup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EstimatedInstanceWarmup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>predefined_scaling_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#predefined_scaling_metric_specification AutoscalingplansScalingPlan#predefined_scaling_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification\"}", isOptional: true)]
            public aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scale_in_cooldown AutoscalingplansScalingPlan#scale_in_cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleInCooldown
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan#scale_out_cooldown AutoscalingplansScalingPlan#scale_out_cooldown}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleOutCooldown
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
