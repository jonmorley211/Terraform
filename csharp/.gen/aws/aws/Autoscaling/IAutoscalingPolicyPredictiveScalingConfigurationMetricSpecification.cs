using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiInterface(nativeType: typeof(IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification")]
    public interface IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        /// <summary>predefined_load_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_load_metric_specification AutoscalingPolicy#predefined_load_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_metric_pair_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_pair_specification AutoscalingPolicy#predefined_metric_pair_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>predefined_scaling_metric_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_scaling_metric_specification AutoscalingPolicy#predefined_scaling_metric_specification}
        /// </remarks>
        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#target_value AutoscalingPolicy#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>predefined_load_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_load_metric_specification AutoscalingPolicy#predefined_load_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification?>();
            }

            /// <summary>predefined_metric_pair_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_metric_pair_specification AutoscalingPolicy#predefined_metric_pair_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification?>();
            }

            /// <summary>predefined_scaling_metric_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/autoscaling_policy#predefined_scaling_metric_specification AutoscalingPolicy#predefined_scaling_metric_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
            public aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification
            {
                get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification?>();
            }
        }
    }
}
